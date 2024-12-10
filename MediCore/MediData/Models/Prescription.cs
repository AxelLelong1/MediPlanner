using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TreatmentPhaseSer", Name = "XIF1Prescription")]
[Index("PredecessorPrescriptionSer", Name = "XIF2Prescription")]
[Index("PrescriptionTemplateSer", Name = "XIF3Prescription")]
public partial class Prescription
{
    [Key]
    public long PrescriptionSer { get; set; }

    [StringLength(64)]
    public string PrescriptionName { get; set; } = null!;

    public long TreatmentPhaseSer { get; set; }

    public long? PredecessorPrescriptionSer { get; set; }

    [StringLength(16)]
    public string? PhaseType { get; set; }

    [StringLength(32)]
    public string? Gating { get; set; }

    public int? SimulationNeeded { get; set; }

    [StringLength(64)]
    public string? BolusFrequency { get; set; }

    [StringLength(64)]
    public string? BolusThickness { get; set; }

    [StringLength(1024)]
    public string? Notes { get; set; }

    [StringLength(64)]
    public string Status { get; set; } = null!;

    public int? NumberOfFractions { get; set; }

    [StringLength(64)]
    public string? Technique { get; set; }

    [StringLength(64)]
    public string? Site { get; set; }

    public long? PrescriptionTemplateSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PredecessorPrescriptionSerNavigation")]
    public virtual ICollection<Prescription> InversePredecessorPrescriptionSerNavigation { get; set; } = new List<Prescription>();

    [InverseProperty("PrescriptionSerNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [ForeignKey("PredecessorPrescriptionSer")]
    [InverseProperty("InversePredecessorPrescriptionSerNavigation")]
    public virtual Prescription? PredecessorPrescriptionSerNavigation { get; set; }

    [InverseProperty("PrescriptionSerNavigation")]
    public virtual ICollection<PrescriptionAnatomy> PrescriptionAnatomy { get; set; } = new List<PrescriptionAnatomy>();

    [InverseProperty("PrescriptionSerNavigation")]
    public virtual ICollection<PrescriptionProperty> PrescriptionProperty { get; set; } = new List<PrescriptionProperty>();

    [ForeignKey("PrescriptionTemplateSer")]
    [InverseProperty("Prescription")]
    public virtual PrescriptionTemplate? PrescriptionTemplateSerNavigation { get; set; }

    [ForeignKey("TreatmentPhaseSer")]
    [InverseProperty("Prescription")]
    public virtual TreatmentPhase TreatmentPhaseSerNavigation { get; set; } = null!;
}
