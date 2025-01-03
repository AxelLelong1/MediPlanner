
#region Dependencies
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Claims;

using MediPlanner.Helper;
using MediPlanner.Enums;
using MediPlanner.Class;
using MediPlanner.Queries;
using MediPlanner.Calculus;
using MediPlanner.QueryResultClass;

using MediData.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System.IO;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

#endregion

namespace MediPlanner
{
    /// <summary>
    /// Test purpose when you want to try Planner features.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTest = new DateTime(2024, 10, 11); // DATE YYYY MM DD
            DateTime Monday = dateTest.AddDays(-(int)dateTest.DayOfWeek + (int)DayOfWeek.Monday);
            var aria = new VarianContext();

            Console.WriteLine("Start up");

            // Création du centre de traitement
            Center center = new Center();
            Localisations localisations = new Localisations();

            // Affichage du tableau des préférences
            Console.WriteLine("Préférences Localisation / Machine\n");
            center.DisplayTreatmentTable();
            Console.WriteLine("\n");

            /* --- DATA GATHERING --- */

            // TODO : BABYPROOFING

            Console.Write("Localisation patient ");
            // var localisation = Console.ReadLine();
            // var loca = localisations.localisations.Where(l => l.Name == localisation).First().Type;

            Console.Write("Nombre de fraction/semaine");
            // var fracions = int.Parse(Console.ReadLine());

            Console.Write("Nombre de semaines");
            // var semaines = int.Parse(Console.ReadLine());

            /* --- DATA HANDLING --- */

            // var machine = center.ChooseMachine(aria, loca, Monday, semaines);

            DBTest(); // machine, dateTest); // TEST REQUEST PURPOSE ONLY

            /*var activites = DBConnect(machine, Monday, semaines).Result;
            Console.WriteLine("----- WEEK AFTER PATIENT ADDED -----");
            AddPatient.AddPatientStabilized(activites, fracions, semaines, new TimeSpan(0, 15, 0));
            SchedulePrettyViewer.print_weeks(machine.GetMachineName(), Monday, semaines, activites);
            */
            Console.ReadLine();
        }

        /// <summary>
        /// Get the activities of a week
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="Monday"></param>
        /// <returns></returns>
        static async Task<List<List<ScheduleQueryResult>>> DBConnect(Class.Machine machine, DateTime Monday, int weeks)
        {
            using (var aria = new VarianContext())
            {
                string MachineName = machine.GetMachineName(); // MACHINE'S NAME (SEE NOTE AND COPY/PASTE)

                CancellationTokenSource cts = new CancellationTokenSource();

                var loadingTask = System.Threading.Tasks.Task.Run(() => LoadingAnimation.loading(cts.Token, "Data"));

                var activities = await (System.Threading.Tasks.Task.Run(() => MachineScheduleQuery.GetScheduleActivity(aria, MachineName, Monday, weeks, [])));

                cts.Cancel(); // Stop the animation

                Console.WriteLine("----- WEEK FROM ARIA -----");
                SchedulePrettyViewer.print_weeks(MachineName, Monday, weeks, activities);

                return activities;
            }
        }

        /// <summary>
        /// TEST REQUEST PURPOSE
        /// TOTAL JUNK AND NON OPTIMISED REQUEST TO SEARCH WHAT I'M LOOKING FOR IN THE HUGE DB
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="date"></param>
        static async void DBTest(Class.Machine? machine = null, DateTime? date = null)
        {

            CancellationTokenSource cts = new CancellationTokenSource();
            var loadingTask = System.Threading.Tasks.Task.Run(() => LoadingAnimation.loading(cts.Token));

            using (var context = new VarianContext())
            {

                // TEST FOR GETTING CURRENT CASE FINISHED AND READY FOR TREATMENT

                /*var test = await (System.Threading.Tasks.Task.Run(() => context.Patient
                    .Join(context.Course, p => p.PatientSer, c => c.PatientSer, (p, c) => new { Patient = p, Course = c })
                    .Join(context.PlanSetup, c => c.Course.CourseSer, plan => plan.CourseSer, (c, plan) => new { c.Patient, c.Course, Plan = plan })
                    .Join(context.PatientHospital, p => p.Patient.PatientSer, hos => hos.PatientSer, (p, hos) => new { p.Patient, p.Course, p.Plan, PatHostpial = hos })
                    .Join(context.Department, p => p.PatHostpial.HospitalSer, d => d.HospitalSer, (p, d) => new { p.Patient, p.Course, p.Plan, Department = d })
                    .Join(context.ResourceGroup, p => p.Department.DepartmentSer, rg => rg.DepartmentSer, (p, rg) => new { p.Patient, p.Course, p.Plan, p.Department, ResourceGroup = rg })
                    //.OrderBy(p => p.Patient.FirstName)
                    .Where(p => // p.Plan.Status == "TreatApproval"  // Plan approuvé
                                // && p.Plan.Status != "Started"     // Ne doit pas être commencé
                                //&& p.Plan.Status != "Completed"   // Ne doit pas être terminé
                                p.ResourceGroup.ResourceGroupCode == "HRH Physique"
                                && p.Patient.LastName.ToUpper() == "KLA"
                                )  // Patient ciblé
                    .OrderBy(p => p.Plan.StatusDate)
                    .Take(100)
                    .ToList()));

                foreach (var t in test)
                {
                    Console.WriteLine("{0} {1} has plan {2} with status {3} (approved on {4}) in department {5}-{6}",
                        t.Patient.FirstName, t.Patient.LastName, t.Plan.PlanSetupId, t.Plan.Status, t.Plan.StatusDate,
                        t.Department.DepartmentId, t.Department.ObjectStatus);
                }


                Console.WriteLine("SEEKING POTENTIAL RDV");

                var act = context.Machine
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
                .Where(joined => joined.act.Activity.ScheduledStartTime.Value.CompareTo(DateTime.Today) >= 0
                                 && joined.act.Activity.ObjectStatus != "Deleted"
                                 && joined.Patient.LastName.ToUpper() == "KLA")
                .OrderBy(joined => joined.act.Activity.ScheduledStartTime)
                .Select(joined => new
                {
                    StartTime = joined.act.Activity.ScheduledStartTime.Value,
                    EndTime = joined.act.Activity.ScheduledEndTime.Value,
                    Status = joined.act.Activity.ObjectStatus,
                    Note = joined.act.Category.ActivityCategoryCode != "Maintenance" ? "TREATMENT" : "MAINTENANCE",
                    Name = (joined.act.Category.ActivityCategoryCode == "Maintenance" ? "Maintenance" : joined.Patient.FirstName + " " + joined.Patient.LastName),
                    Machine = joined.act.m.MachineName
                })
                .ToList();

                foreach (var t in act)
                {
                    Console.WriteLine("{0} {1}-{2} on {3}. Status : {4}", t.Name, t.StartTime, t.EndTime, t.Machine, t.Status);
                }*/


                /*var test = await System.Threading.Tasks.Task.Run(() => context.TreatmentCycle
               .Join(
                    context.Activity,
                    context => context.CycleSer,
                    act => act.TreatmentCycleSer,
                    (context, act) => new { Cycle = context, Activity = act }
                    )
                .Join(context.ActivityInstance,
                context => context.Activity.ActivitySer,
                inst => inst.ActivitySer,
                (context, inst) => new { context.Cycle, context.Activity, Instance = inst})
                .Join(context.NonScheduledActivity,
                context => context.Instance.ActivityInstanceSer,
                nsa => nsa.ActivityInstanceSer,
                (context, nsa) => new { context.Cycle, context.Activity, context.Instance, NSA = nsa })
                .Join(context.Patient,
                context => context.NSA.PatientSer,
                pat => pat.PatientSer,
                (context, pat) => new { context.Cycle, context.Activity, context.Instance, context.NSA, Patient = pat })
                .OrderBy(x => x.Activity.ActivityCode)
                .Where(x => x.Activity.HstryDateTime.CompareTo(new DateTime(2024,09,01)) > 0)
                //.Where(context => context.Patient.LastName.ToUpper() == "GRIMBERT" && context.Patient.FirstName.ToUpper() == "GILLES") // Dosimétrie Vmat St Cloud | Dosimétrie RC3D St Cloud | Dosimétrie Strereo St Cloud
                .ToList());
                
                 
                foreach (var act in test)
                {
                    Console.WriteLine($"{act.Patient.LastName} {act.Patient.FirstName} - {act.Activity.ActivityCode}"); /// ??????????
                }
                */

                /*var test = await System.Threading.Tasks.Task.Run(() => context.Diagnosis
                .Select(x => new { name = x.DiagnosisTableName, 
                                   code = x.DiagnosisCode })
                .ToList());*/

                /*
                
                var test = await System.Threading.Tasks.Task.Run(() => context.PlanSetup
                .Select(x => new { Name = x.PlanSetupName })
                .Distinct()
                .Take(100).OrderBy(x => x.Name).ToList());



                .Join(context.Rtplan,
                x => x.PlanSetupSer,
                rt => rt.PlanSetupSer,
                (x, rt) => new { Plan = x, RT = rt })
                .Join(context.TreatmentRecord,
                x => x.RT.PlanUid,
                treat => treat.PlanUid,
                (x, treat) => new { x.Plan, x.RT, Treatment = treat})
                .Join(context.Patient,
                x => x.Treatment.PatientSer,
                pat => pat.PatientSer,
                (x, pat) => new { x.Plan, x.RT, x.Treatment, Pat = pat }).Take(100000).ToList()
                */

                var test = await System.Threading.Tasks.Task.Run(() => context.PlanSetup
                .Where(x => x.PlanSetupName != string.Empty && x.PlanSetupName != null)
                .Join(context.Rtplan,
                x => x.PlanSetupSer,
                rt => rt.PlanSetupSer,
                (x, rt) => new { Plan = x, RT = rt })
                .Join(context.TreatmentRecord,
                x => x.RT.PlanUid,
                treat => treat.PlanUid,
                (x, treat) => new { x.Plan, x.RT, Treatment = treat })
                .Join(context.Patient,
                x => x.Treatment.PatientSer,
                pat => pat.PatientSer,
                (x, pat) => new { x.Plan, x.RT, x.Treatment, Pat = pat })
                .Select(x => new { Plan = x.Plan.PlanSetupName, Pat = x.Pat.LastName })
                .Distinct()
                .ToList());

                cts.Cancel(); // Stop the animation
                await loadingTask;

                foreach(var t in test)
                {
                    Console.WriteLine("{0} - {1}", t.Plan, (t.Pat));
                }

                
                Console.WriteLine("STATS");
                Console.WriteLine("GOT {0} ENTRIES", test.Count);
                Console.WriteLine("{0} Sein ENTRIES", test.Where(x => x.Plan.ToUpper().Contains("SEIN")).Count());

                var loca = test.Select(x => x.Plan).Distinct().ToList();


                foreach (var l in loca)
                {
                    Console.WriteLine("{0}", l);
                }

                //string MachineName = machine.GetMachineName(); // MACHINE'S NAME (SEE NOTE AND COPY/PASTE)

                //var activities = await (Task.Run(() => MachineScheduleQuery.GetActivityOnADay(MachineName, date)));

                //SchedulePrettyViewer.pretty_print(machine.GetMachineName(), date, activities);
            }
        }
    }
}

#region Notes
/* ------- NOTES ------- */

/* --- MACHINES --- */

/*
 * TRUEBEAM
 * TRUEBEAM2
 * NOVALISTX
 * HALCYON SC
*/
#endregion