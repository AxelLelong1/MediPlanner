using MediPlanner.QueryResultClass;

namespace MediPlanner.Class
{
    /// <summary>
    /// Patient handler
    /// Contains name and list of event conerning itself
    /// </summary>
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ScheduleQueryResult> Schedules { get; set; }

        public Patient()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Schedules = new List<ScheduleQueryResult>();
        }

        public Patient(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Schedules = new List<ScheduleQueryResult>();
        }

        public Patient(string firstName, string lastName, List<ScheduleQueryResult> schedules) : this(firstName, lastName)
        {
            Schedules = schedules;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
