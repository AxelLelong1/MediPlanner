using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TreatmentRecordUid", Name = "XAK1TreatmentRecord", IsUnique = true)]
[Index("PlanUid", Name = "XIE3TreatmentRecord")]
[Index("HstryDateTime", Name = "XIE5TreatmentRecord")]
[Index("TreatmentRecordDateTime", Name = "XIE6TreatmentRecord")]
[Index("RtplanSer", Name = "XIF1TreatmentRecord")]
[Index("SeriesSer", Name = "XIF2TreatmentRecord")]
[Index("PlanSopclassSer", Name = "XIF3TreatmentRecord")]
[Index("TreatmentRecordSopclassSer", Name = "XIF4TreatmentRecord")]
[Index("PatientSer", Name = "XIF5TreatmentRecord")]
[Index("ActualMachineSer", Name = "XIF6TreatmentRecord")]
public partial class TreatmentRecord
{
    [Key]
    public long TreatmentRecordSer { get; set; }

    public long PatientSer { get; set; }

    public long SeriesSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }

    [Column("PlanSOPClassSer")]
    public long PlanSopclassSer { get; set; }

    [Column("TreatmentRecordSOPClassSer")]
    public long TreatmentRecordSopclassSer { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    [Column("TreatmentRecordUID")]
    [StringLength(64)]
    public string TreatmentRecordUid { get; set; } = null!;

    [StringLength(254)]
    public string? FileName { get; set; }

    public long? ActualMachineSer { get; set; }

    [StringLength(64)]
    public string? ActualMachineAuthorization { get; set; }

    public byte MachOverrideFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("StructureSetUID")]
    [StringLength(64)]
    public string? StructureSetUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentRecordDateTime { get; set; }

    public int? NoOfFractions { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }

    [ForeignKey("ActualMachineSer")]
    [InverseProperty("TreatmentRecord")]
    public virtual RadiationDevice? ActualMachineSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("TreatmentRecord")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("PlanSopclassSer")]
    [InverseProperty("TreatmentRecordPlanSopclassSerNavigation")]
    public virtual Sopclass PlanSopclassSerNavigation { get; set; } = null!;

    [InverseProperty("TreatmentRecordSerNavigation")]
    public virtual ICollection<RadiationHstry> RadiationHstry { get; set; } = new List<RadiationHstry>();

    [ForeignKey("RtplanSer")]
    [InverseProperty("TreatmentRecord")]
    public virtual Rtplan? RtplanSerNavigation { get; set; }

    [ForeignKey("SeriesSer")]
    [InverseProperty("TreatmentRecord")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [ForeignKey("TreatmentRecordSopclassSer")]
    [InverseProperty("TreatmentRecordTreatmentRecordSopclassSerNavigation")]
    public virtual Sopclass TreatmentRecordSopclassSerNavigation { get; set; } = null!;
}
