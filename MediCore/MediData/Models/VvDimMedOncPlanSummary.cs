using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimMedOncPlanSummary
{
    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    public int PlanSumType { get; set; }

    [StringLength(30)]
    public string? PlanSumTypeDesc { get; set; }

    [StringLength(3000)]
    public string? PlanSumDescription { get; set; }
}
