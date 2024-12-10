using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediPlanner.QueryResultClass;

namespace MediPlanner.Calculus
{
    public class AddPatient
    {
        static public void AddPatientAtEarliest(List<List<ScheduleQueryResult>> activites, int fractions, int weeks, TimeSpan treatmentTime, TimeSpan? pref = null)
        {
            TimeSpan? preferredStartTime = pref;
            ScheduleQueryResult slotAtPreferredTime;
            ScheduleQueryResult booked = null;

            for (int i = 0; i < weeks; i++)
            {
                int f = fractions;
                foreach (var day in activites.Skip(i * 7).Take(6).ToList())
                {
                    if (f <= 0)
                        break; // Si le nombre de fraction voulu est atteint, on arrête

                    // on n'a pas d'heure préférée ... Il faut donc la trouver
                    if (preferredStartTime == null)
                    {
                        var earliestSlot = day
                                              .Where(s => s.Status == "FREE" && (s.EndTime - s.StartTime) >= treatmentTime) // Avoir toutes les 'FREE' plages
                                              .OrderBy(s => s.StartTime.TimeOfDay) // Avoir la plus proche
                                              .FirstOrDefault();

                        if (earliestSlot != null)
                            preferredStartTime = earliestSlot.StartTime.TimeOfDay;
                    }

                    if (preferredStartTime != null)
                    {
                        slotAtPreferredTime = day.FirstOrDefault(slot => // Chercher la plage libre a cette heure pour ce jour
                                                    slot.Status == "FREE" &&
                                                    slot.StartTime.TimeOfDay == preferredStartTime &&
                                                    (slot.EndTime - slot.StartTime) >= treatmentTime);

                        if (slotAtPreferredTime == null) // plage non-trouvée ... il faut trouver la plus proche
                        {
                            slotAtPreferredTime = day
                                .Where(slot => slot.Status == "FREE" && (slot.EndTime - slot.StartTime) >= treatmentTime)
                                .OrderBy(slot => Math.Abs((slot.StartTime.TimeOfDay - preferredStartTime.Value).TotalMinutes))
                                .FirstOrDefault();
                        }

                        if (slotAtPreferredTime != null) // plage trouvée
                        {
                            booked = new ScheduleQueryResult(
                                slotAtPreferredTime.StartTime,
                                slotAtPreferredTime.StartTime + treatmentTime,
                                "BOOKED",
                                "BOOKED",
                                "BOOKED HERE (replace by real name)");

                            var old = day.Find(s => s == slotAtPreferredTime);
                            day.Insert(day.IndexOf(old), booked);

                            old.StartTime = booked.EndTime;
                            if (old.EndTime - old.StartTime < new TimeSpan(0, 15, 0))
                                day.Remove(old);

                            f--;
                        }
                    }
                }

                if (f > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Coudln't place all fractions for the {0:dd/MM} week!", activites.Skip(i * 7).Take(1).ToList()[0][0].StartTime); // Notify we coundl't put the patient where we wanted during a specific week
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        static public void AddPatientStabilized(string name, string surname, List<List<ScheduleQueryResult>> activites, int fractions, int weeks, TimeSpan treatmentTime, TimeSpan pref)
        {
            TimeSpan preferredStartTime = pref;
            ScheduleQueryResult slotAtPreferredTime;
            ScheduleQueryResult? booked = null;

            for (int i = 0; i < weeks; i++)
            {
                int f = fractions;

                // Pour chaque semaine (6 jours), nous traitons les activités
                foreach (var day in activites.Skip(i * 7).Take(6).ToList())
                {
                    if (f <= 0)
                        break; // Si le nombre de fraction voulu est atteint, on arrête

                    // Si une heure préférée est maintenant définie
                    if (preferredStartTime != null)
                    {

                        // TODO: Redo Logic
                        // Currently, it only consider starting times
                        // But by taking into consideration ending time too, we couldn find other preferable slots
                        //
                        // e.g. Preffered time is 10h15
                        // There are 3 free slots that day
                            // 8-10:30
                            // 10:45-11
                            // 14-16

                        // As 10:45 is closer to 10:15 than 8, second slot is chosen
                        // but there is an existiing available slot at 10:15 inside the first that as not been detected ...

                        slotAtPreferredTime = day
                            .Where(slot => slot.Status == "FREE" && (slot.EndTime - slot.StartTime) >= treatmentTime)
                            .OrderBy(slot => Math.Abs((slot.StartTime.TimeOfDay - preferredStartTime).TotalMinutes))
                            .FirstOrDefault();

                        // Si une plage est trouvée, on place la fraction du patient
                        if (slotAtPreferredTime != null)
                        {
                            var bookStartTime = slotAtPreferredTime.StartTime;
                            var bookEndTime = bookStartTime.Add(treatmentTime);
                            var ecart = Math.Abs((bookStartTime.TimeOfDay - preferredStartTime).TotalMinutes);

                            // Avancer progressivement le créneau jusqu'à trouver la meilleure position
                            while (bookEndTime.Add(treatmentTime) <= slotAtPreferredTime.EndTime &&
                                   Math.Abs((bookStartTime.Add(treatmentTime).TimeOfDay - preferredStartTime).TotalMinutes) < ecart)
                            {
                                // Déplacer la plage de traitement de 'treatmentTime' et recalculer l'écart
                                bookStartTime = bookStartTime.Add(treatmentTime);
                                bookEndTime = bookEndTime.Add(treatmentTime);

                                // Recalculer l'écart
                                ecart = Math.Abs((bookStartTime.TimeOfDay - preferredStartTime).TotalMinutes);
                            }

                            booked = new ScheduleQueryResult(
                                bookStartTime,
                                bookEndTime,
                                "BOOKED",
                                "BOOKED",
                                name + " " + surname);

                            // On remplace l'ancienne plage avec la nouvelle réservation
                            var old = day.Find(s => s == slotAtPreferredTime);
                            day.Add(booked);

                            if (booked.StartTime == old.StartTime) // Booked is at the beginning
                                old.StartTime = booked.EndTime;

                            else if (booked.EndTime == old.EndTime) // Booked is at the end
                                old.EndTime = booked.StartTime;

                            else // Booked splice the free slot in two
                            {
                                if (old.EndTime - booked.EndTime >= new TimeSpan(0,15,0)) // make sure we have enough time for the after slot before creating it !
                                    day.Add(new ScheduleQueryResult // create the after free slot
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        StartTime = booked.EndTime,
                                        EndTime = old.EndTime,
                                        Status = "FREE",
                                        Note = "FREE",
                                        Name = "Available Slot"
                                    });

                                old.EndTime = booked.StartTime; // re-shape the before slot
                            }

                            if (old.EndTime - old.StartTime < new TimeSpan(0, 15, 0)) // The before slot is too small
                                day.Remove(old);

                            day.Sort((e, ee) => e.StartTime.CompareTo(ee.StartTime));

                            // Fraction placed !
                            f--;
                        }
                    }
                }

                // We coudln't place all fractions ..
                if (f > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Couldn't place all fractions for the {0:dd/MM} week!", activites.Skip(i * 7).Take(1).ToList()[0][0].StartTime);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}