using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlanner.Queries.Request
{
    public class UpdateScheduleRequest
    {
        public string ScheduleId { get; set; }
        public DateTime NewStart { get; set; }
        public DateTime NewEnd { get; set; }
        public string MachineName { get; set; }
    }
}
