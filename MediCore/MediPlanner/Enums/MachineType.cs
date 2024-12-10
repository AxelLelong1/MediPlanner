using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediPlanner.Enums
{
    public enum MachineType
    {
        [Display(Name = "TRUEBEAM")]
        TRUEBEAM,
        [Display(Name = "TRUEBEAM2")]
        TRUEBEAM2,
        [Display(Name = "NOVALISTX")]
        NOVALISTX,
        [Display(Name = "HALCYON SC")]
        HALCYONSC
    }
}
