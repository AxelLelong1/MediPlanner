using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimBrachyField
{
    [StringLength(32)]
    public string? BrachyFieldTypeInfo { get; set; }

    public double? ApplicatorLength { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PlannedTreatmDateTime { get; set; }

    public double? StepSize { get; set; }

    public double? FirstSourcePosition { get; set; }

    public double? LastSourcePosition { get; set; }

    public int? AutomaticPosFlag { get; set; }

    [Column("ApplicatorPartChannelUID")]
    public int? ApplicatorPartChannelUid { get; set; }

    public double? DeadSpace { get; set; }

    [StringLength(16)]
    public string? BrachySolidApplicatorId { get; set; }

    [StringLength(64)]
    public string? BrachySolidApplicatorName { get; set; }

    [Column("BrachySolidApplicatorApplicatorPartUID")]
    [StringLength(64)]
    public string? BrachySolidApplicatorApplicatorPartUid { get; set; }

    [StringLength(254)]
    public string? BrachySolidApplicatorPartFileName { get; set; }

    [StringLength(254)]
    public string? BrachySolidApplicatorComment { get; set; }

    [Column("ctrRadiationSer")]
    public long CtrRadiationSer { get; set; }

    [Column("ctrChannelSer")]
    public long? CtrChannelSer { get; set; }

    [Column("ctrBrachyApplicatorSer")]
    public long? CtrBrachyApplicatorSer { get; set; }

    [Column("ctrBrachySolidApplicatorSer")]
    public long? CtrBrachySolidApplicatorSer { get; set; }

    [Column("ctrBrachySolidApplicatorPlanSetupSer")]
    public long? CtrBrachySolidApplicatorPlanSetupSer { get; set; }

    [StringLength(255)]
    public string? BrachySolidApplicatorHstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BrachySolidApplicatorHstryDateTime { get; set; }
}
