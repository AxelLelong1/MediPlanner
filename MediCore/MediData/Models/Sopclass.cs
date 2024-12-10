using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("SOPClass")]
public partial class Sopclass
{
    [Key]
    [Column("SOPClassSer")]
    public long SopclassSer { get; set; }

    [Column("SOPClassUID")]
    [StringLength(64)]
    public string SopclassUid { get; set; } = null!;

    [StringLength(128)]
    public string? Name { get; set; }

    [StringLength(64)]
    public string? Category { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("SopclassSerNavigation")]
    public virtual ICollection<ImageRelatedInstance> ImageRelatedInstance { get; set; } = new List<ImageRelatedInstance>();

    [InverseProperty("SopclassSerNavigation")]
    public virtual ICollection<ObjectPointer> ObjectPointer { get; set; } = new List<ObjectPointer>();

    [InverseProperty("RelatedPlanSopclassSerNavigation")]
    public virtual ICollection<PlanRelationship> PlanRelationship { get; set; } = new List<PlanRelationship>();

    [InverseProperty("SopclassSerNavigation")]
    public virtual ICollection<ProcedureItemSopclass> ProcedureItemSopclass { get; set; } = new List<ProcedureItemSopclass>();

    [InverseProperty("RefImageSopclassSerNavigation")]
    public virtual ICollection<Radiation> Radiation { get; set; } = new List<Radiation>();

    [InverseProperty("PlanSopclassSerNavigation")]
    public virtual ICollection<Rtplan> Rtplan { get; set; } = new List<Rtplan>();

    [InverseProperty("SopclassSerNavigation")]
    public virtual ICollection<Slice> Slice { get; set; } = new List<Slice>();

    [InverseProperty("PlanSopclassSerNavigation")]
    public virtual ICollection<TreatmentRecord> TreatmentRecordPlanSopclassSerNavigation { get; set; } = new List<TreatmentRecord>();

    [InverseProperty("TreatmentRecordSopclassSerNavigation")]
    public virtual ICollection<TreatmentRecord> TreatmentRecordTreatmentRecordSopclassSerNavigation { get; set; } = new List<TreatmentRecord>();
}
