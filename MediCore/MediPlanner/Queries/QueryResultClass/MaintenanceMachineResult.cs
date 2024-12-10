using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlanner.Queries.QueryResultClass
{
    public class MaintenanceMachineResult
    {
        public string MachineName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MaintenanceMachineResult(string name, DateTime start, DateTime end) {
            MachineName = name;
            StartDate = start;
            EndDate = end;
        }
    }
}
