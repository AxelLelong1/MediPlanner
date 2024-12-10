using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimMedoncPlanPhase
{
    [Column("ctrtp_name")]
    [StringLength(20)]
    public string? CtrtpName { get; set; }

    [Column("ctrtp_vers_no")]
    [StringLength(10)]
    public string? CtrtpVersNo { get; set; }

    [Column("ctrphase_seq_no")]
    public int CtrphaseSeqNo { get; set; }

    [StringLength(100)]
    public string PhaseDescription { get; set; } = null!;

    public int NoOfCycles { get; set; }

    public int? AllowableDrift { get; set; }

    public int? AllowableDelay { get; set; }

    public int? TimePeriodDuration { get; set; }

    public int? TimePeriodDurationUnit { get; set; }

    public int? LengthOfCycle { get; set; }

    [StringLength(3000)]
    public string? PhaseBriefDescription { get; set; }

    [StringLength(3000)]
    public string? ConsentDescription { get; set; }

    [StringLength(1)]
    public string? RequiredIndicator { get; set; }
}
