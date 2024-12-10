using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlanner.Queries.Request
{

public class EditMachinePrefRequest
    {
        public int champsX { get; set; }
        public int champsY { get; set; }
        public Dictionary<string, Tuple<int, bool>> localisations { get; set; }
    }
}
