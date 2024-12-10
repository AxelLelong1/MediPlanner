using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediPlanner.Class;

namespace MediPlanner.Queries.QueryResultClass
{
    public class PreferredMachineResult
    {
        public Machine Preferred { get; set; }
        public Machine Optimum { get; set; }

        public PreferredMachineResult()
        {
            Preferred = null;
            Optimum = null;
        }
    }
}
