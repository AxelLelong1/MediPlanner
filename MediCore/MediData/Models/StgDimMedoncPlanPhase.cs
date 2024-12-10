using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimMedoncPlanPhase", Schema = "DWH")]
public partial class StgDimMedoncPlanPhase
{
    [Column("tp_name")]
    [StringLength(40)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(20)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }
}
