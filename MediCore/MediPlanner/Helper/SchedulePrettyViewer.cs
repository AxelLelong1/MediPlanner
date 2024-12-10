using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediData;
using MediPlanner.QueryResultClass;

namespace MediPlanner.Helper
{
    class SchedulePrettyViewer
    {
        /// <summary>
        /// Print in a human readable way the planning of a said machine for a said date 
        /// </summary>
        /// <param name="machineName">IN CAPITAL LETTER, refer to the note to know the name of the machine</param>
        /// <param name="date">DateTime YYYY MM DD</param>
        /// <param name="activities">The scheduled activities of the machine</param>
        static public void pretty_print(string machineName, DateTime date, List<ScheduleQueryResult> activities)
        {
            Console.WriteLine("Table for {0} the {1:d}", machineName, date);
            Console.WriteLine("|  {0:-15}  |  {1:-9}   | {2:-9} | {3:-20}","Start - End", "Time", "Status", "Category");
            Console.WriteLine("-------------------------------------");


            foreach (var a in activities)
            {
                TimeSpan duration = a.EndTime.Subtract(a.StartTime);
                Console.Write("| {0:00}:{1:00} - {2:00}:{3:00} |  {4:00}:{5:00}  |", a.StartTime.Hour, a.StartTime.Minute, 
                                                                                                a.EndTime.Hour, a.EndTime.Minute, 
                                                                                                duration.Hours, duration.Minutes);
                
                // Fancy Color 
                Console.ForegroundColor = GetColor(a.Status);
                Console.Write(" {0,-6} |", a.Status);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" {0:-20}", a.Note);

                Console.WriteLine(" |");
            }

            Console.WriteLine("-------------------------------------");
        }

        /// <summary>
        /// Print in a human readable way the planning of a machine for an entire workday week (mon -> fri)
        /// </summary>
        /// <param name="machineName">Machine name</param>
        /// <param name="date">YYYY MM DD (Monday obligatory)</param>
        /// <param name="week">Activities of the week (list of list of activities)</param>
        static public void print_week(string machineName, DateTime date, List<List<ScheduleQueryResult>> week)
        {
            Console.WriteLine($"Schedule for {machineName} during the {date:yyyy MM dd}");

            // Print the headers for days
            Console.Write("Time         ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{date.AddDays(i):ddd}{date.AddDays(i):dd/MM}                            "); // Day of the week
            }
            Console.WriteLine();

            // Find the maximum number of activities in any day
            int maxActivities = week.Max(dayActivities => dayActivities.Count);

            // Print each activity row by row
            for (int i = 0; i < maxActivities; i++)
            {
                // First column is for time slots
                Console.Write("Slot {0:00} :    ", i + 1);

                // Loop through each day's activities
                for (int day = 0; day < 6; day++)
                {
                    if (i < week[day].Count)
                    {
                        var activity = week[day][i];
                        Console.ForegroundColor = GetColor(activity.Status);

                        Console.Write($"{activity.StartTime:HH:mm}-{activity.EndTime:HH:mm} | ({(activity.EndTime - activity.StartTime).TotalMinutes:0000}) | "); // print starttime / endtime / duration
                        Console.Write("{0,-6} | ", activity.Status); // print the status
                        Console.Write("{0, -1} || ", GetCode(activity.Note)); // print other things needed for understading things (Maintenance ? holiday ?)

                        Console.ForegroundColor = ConsoleColor.White;
                        ;                    }
                    else
                    {
                        Console.Write("            |        |        |   || "); // If there's no activity in this slot for the day
                    }
                }
                Console.WriteLine(); // Move to the next row
            }
        }

        static public void print_weeks(string machineName, DateTime date, int weeks, List<List<ScheduleQueryResult>> week)
        {
            for (int i = 0; i < weeks; i++)
            {
                print_week(machineName, date.AddDays(i * 7), week.Skip(i * 7).ToList()); // print a week
                for (int j = 0; j < 59; j++)
                    Console.Write("--- "); // *Fancy* separation
                Console.WriteLine();
            }
        }

        static private ConsoleColor GetColor(string CODE)
        {
            switch(CODE)
            {
                case "FREE": return ConsoleColor.Green;
                case "BOOKED": return ConsoleColor.Yellow;
                case "Maintenance": return ConsoleColor.DarkGray;
                case "Signal": return ConsoleColor.DarkGray;
                default: return ConsoleColor.White;
            }
        }

        static private string GetCode(string CODE)
        {
            switch(CODE)
            {
                case "Maintenance": return "M";
                case "Vacances": return "V";
                case "Signal": return "S";
                default: return "O";
            }
        }
    }
}
