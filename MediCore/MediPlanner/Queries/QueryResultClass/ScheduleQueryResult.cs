using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlanner.QueryResultClass
{
    public class ScheduleQueryResult
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int centerId { get; set; }
        public string Machine { get; set; }
        public string Status { get; set; } 
        public string Note { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }

        public ScheduleQueryResult()
        {
            Id = "NULL";
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
            Machine = "NULL";
            Status = "NULL";
            Note = "NULL";
            Name = "NULL";
        }
        public ScheduleQueryResult(DateTime S, DateTime E, string status)
        {
            Id = Guid.NewGuid().ToString();
            StartTime = S;
            EndTime = E;
            Status = status;
            centerId = -1;
            Note = "NULL";
            Machine = "NULL";
            Name = "NULL";
        }
        public ScheduleQueryResult(DateTime S, DateTime E, string status, string note) : this (S, E, status)
        {
            Id = Guid.NewGuid().ToString();
            Note = note;
            Name = "NULL";
            Machine = "NULL";
        }

        public ScheduleQueryResult(DateTime S, DateTime E, string status, string note, string name) : this (S, E, status, note)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Machine = "NULL";
        }

        public ScheduleQueryResult(DateTime S, DateTime E, string status, string note, string name, string machine) : this(S, E, status, note, name)
        {
            Machine = machine;
        }

        public ScheduleQueryResult(DateTime S, DateTime E, string status, string note, string name, string machine, int centerId) : this(S, E, status, note, name, machine)
        {
            this.centerId = centerId;
        }

        override public string ToString()
        {
            return string.Format("{0} {1} {2} {3}-{4}", Name, Note, Status, StartTime, EndTime);
        }
    }
}
