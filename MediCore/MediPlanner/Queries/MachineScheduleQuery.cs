using System;
using System.Collections.Generic;
using System.Linq;

using Azure;

using MediData.Models;

using MediPlanner.Queries.QueryResultClass;
using MediPlanner.QueryResultClass;

namespace MediPlanner.Queries
{
    public class MachineScheduleQuery
    {

        // Constantes
        const int MIN_FREE_TIME = 10; // Minimum 10 minutes de temps libre
        const double MACHINE_START_HOUR = 7.5;
        const double MACHINE_END_HOUR = 19.09;

        /// <summary>
        /// Récupère les activités d'une machine pour un jour donné.
        /// </summary>
        static public List<ScheduleQueryResult> GetActivityOnADay(VarianContext context, string machineName, DateTime date)
        {
            List<ScheduleQueryResult> activities = QueryMachineActivities(context, machineName, date, date);

            // Ajoute les plages libres
            FillFreeSlots(activities);

            return activities;
        }

        /// <summary>
        /// Récupère les activités d'une machine sur une plage de plusieurs semaines.
        /// </summary>
        static public List<List<ScheduleQueryResult>> GetScheduleActivity(VarianContext context, string machineName, DateTime startDate, int weeks, List<Class.Patient> patients)
        {


            DateTime endDate = startDate.AddDays(7 * weeks);

            // Récupère les activités
            List<ScheduleQueryResult> activities = QueryMachineActivities(context, machineName, startDate, endDate);

            // Ajoute les vacances
            activities = activities.Concat(GetHolidays(context, startDate, endDate)).ToList();
            patients.ForEach(x => {
                foreach (var sch in x.Schedules)
                    if (sch.Machine == machineName)
                        activities.Add(sch);
                /*if (x.MachineName == machineName)
                    activities = activities.Concat(x.Schedules).ToList();*/
            });

            // Ajoute les signaux
            AddSignals(activities, startDate, weeks);

            // Grouper les activités par jour
            List<List<ScheduleQueryResult>> groupedActivities = GroupActivitiesByDay(activities, weeks);

            foreach (var day in groupedActivities)
                FillFreeSlots(day);
            
            return groupedActivities;
        }

        /// <summary>
        /// Récupère les activités planifiées pour une machine donnée entre deux dates.
        /// </summary>
        private static List<ScheduleQueryResult> QueryMachineActivities(VarianContext context, string machineName, DateTime startDate, DateTime endDate)
        {
            if (startDate.CompareTo(endDate) == 0)
                endDate = endDate.AddDays(1);

            return context.Machine
                .Where(m => m.MachineName.ToUpper() == machineName.ToUpper())
                .Join(context.Attendee, m => m.ResourceSer, a => a.ResourceSer, (m, a) => new { m, a })
                .Join(context.ScheduledActivity, ma => ma.a.ActivityInstanceSer, sa => sa.ActivityInstanceSer, (ma, sa) => new { ma.m, Activity = sa })
                .Join(context.ActivityInstance, sa => sa.Activity.ActivityInstanceSer, actI => actI.ActivityInstanceSer, (sa, act) => new { sa.m, sa.Activity, Instance = act })
                .Join(context.Activity, actI => actI.Instance.ActivitySer, act => act.ActivitySer, (actI, act) => new { actI.m, actI.Activity, actI.Instance, Details = act })
                .Join(context.ActivityCategory, act => act.Details.ActivityCategorySer, actC => actC.ActivityCategorySer, (act, actC) => new { act.m, act.Activity, Category = actC })
                .GroupJoin(
                        context.Patient,
                        act => act.Activity.PatientSer,
                        p => p.PatientSer,
                        (act, patients) => new { act, Patient = patients } // Utilisation de DefaultIfEmpty pour les left joins car les mainetnances n'ont pas de patients assignés
                    )
                .SelectMany(x => x.Patient.DefaultIfEmpty(), (x, patient) => new { x.act, Patient = patient })
                .Where(joined => joined.act.Activity.ScheduledStartTime.Value.CompareTo(startDate) >= 0
                                 && joined.act.Activity.ScheduledStartTime.Value.CompareTo(endDate) < 0
                                 && joined.act.Activity.ObjectStatus != "Deleted")
                .OrderBy(joined => joined.act.Activity.ScheduledStartTime)
                .Select(joined => new ScheduleQueryResult
                {
                    Id = joined.act.Activity.Uid,
                    StartTime = joined.act.Activity.ScheduledStartTime.Value,
                    EndTime = joined.act.Activity.ScheduledEndTime.Value,
                    Status = joined.act.Activity.ObjectStatus,
                    Note = joined.act.Category.ActivityCategoryCode != "Maintenance" ? "TREATMENT" : "MAINTENANCE",
                    Name = (joined.act.Category.ActivityCategoryCode == "Maintenance" ? "Maintenance" : joined.Patient.FirstName + " " + joined.Patient.LastName),
                    Machine = machineName
                })
                .ToList();
        }

        /// <summary>
        /// Récupère les vacances planifiées.
        /// </summary>
        private static List<ScheduleQueryResult> GetHolidays(VarianContext context, DateTime startDate, DateTime endDate)
        {
            return context.ScheduleHoliday
                .Where(h => h.StartDateTime.CompareTo(startDate) >= 0 && h.StartDateTime.CompareTo(endDate) < 0)
                .Select(h => new ScheduleQueryResult
                {
                    Id = h.HolidayId,
                    StartTime = h.StartDateTime,
                    EndTime = h.EndDateTime,
                    Status = "Vacs",
                    Note = "HOLIDAY",
                    Name = "Holiday"
                })
                .ToList();
        }

        /// <summary>
        /// Ajoute des signaux "Signal" à des heures spécifiques pour chaque jour.
        /// </summary>
        private static void AddSignals(List<ScheduleQueryResult> activities, DateTime startDate, int weeks)
        {
            for (int i = 0; i < weeks; i++)
            {
                for (var j = 0; j < 7; j++)
                {
                    DateTime currentDay = startDate.AddDays(i * 7 + j);
                    activities.Insert(0, new ScheduleQueryResult(currentDay.AddHours(MACHINE_START_HOUR), currentDay.AddHours(MACHINE_START_HOUR), "Signal", "SIGNAL", "Signal"));
                    activities.Add(new ScheduleQueryResult(currentDay.AddHours(MACHINE_END_HOUR), currentDay.AddHours(MACHINE_END_HOUR), "Signal", "SIGNAL", "Signal"));
                }
            }
        }

        /// <summary>
        /// Groupe les activités par jour.
        /// </summary>
        private static List<List<ScheduleQueryResult>> GroupActivitiesByDay(List<ScheduleQueryResult> activities, int weeks)
        {
            activities = activities.OrderBy(x => x.StartTime).ToList();
            return activities
                        .GroupBy(activity => activity.StartTime.Date)
                        .OrderBy(group => group.Key)
                        .Select(group => group.ToList())
                        .ToList();
        }

        /// <summary>
        /// Ajoute des plages libres si nécessaire.
        /// </summary>
        private static void FillFreeSlots(List<ScheduleQueryResult> activities)
        {
            DateTime maxEndTime = DateTime.MinValue;
            bool CanPlace = false;

            for (int i = 0; i < activities.Count - 1; i++)
            {
                if (activities[i].Name == "Signal")
                    continue;
                if (activities[i].Name.Contains("TOP"))
                    CanPlace = true;

                DateTime endFirst = activities[i].EndTime;
                DateTime startSecond = activities[i + 1].StartTime;

                if (endFirst > maxEndTime)
                    maxEndTime = endFirst;

                if (maxEndTime < startSecond && startSecond.Subtract(maxEndTime) >= TimeSpan.FromMinutes(MIN_FREE_TIME))
                {
                    if (CanPlace)
                    {
                        activities.Insert(i + 1, new ScheduleQueryResult
                        {
                            Id = Guid.NewGuid().ToString(),
                            StartTime = maxEndTime,
                            EndTime = startSecond,
                            Status = "FREE",
                            Note = "FREE",
                            Name = "Libre"
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Récupère le temps d'utilisation total d'une machine sur une période donnée.
        /// </summary>
        static public double GetMachineUsedTime(VarianContext context, string machineName, DateTime startDate, int weeks)
        {
            DateTime endDate = startDate.AddDays(7 * weeks);

            var activities = QueryMachineActivities(context, machineName, startDate, endDate);

            return activities.Sum(act => act.EndTime.Subtract(act.StartTime).TotalMinutes);
        }

        /// <summary>
        /// Récupère le nombre de patients sur une machine
        /// </summary>
        /// <param name="machineName"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
        static public double GetMachineNumberPatient(VarianContext context, string machineName, DateTime startDate)
        {
            var activites = QueryMachineActivities(context, machineName, startDate, startDate);

            return activites.Where(a => a.Note != "MAINTENANCE").Count();
        }

        /// <summary>
        /// Renvoie si la machine a des maintenances le jour donné
        /// </summary>
        /// <param name="machineName"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
        static public MaintenanceMachineResult? GetMaintenance(VarianContext context, string machineName, DateTime startDate)
        {
            var activites = QueryMachineActivities(context, machineName, startDate, startDate);

            var maintenance = activites
                .Where(a => a.Note == "MAINTENANCE"
                            && (a.StartTime >= DateTime.Now // soon to come maintenance
                                || (a.StartTime < DateTime.Now 
                                    && a.EndTime > DateTime.Now))) // maintenance on going
                .Select(a => new MaintenanceMachineResult(machineName, a.StartTime, a.EndTime))
                .OrderBy(a => a.StartDate)
                .ToList();

            return maintenance.Count > 0 ? maintenance[0] : null;
        }
    }
}
