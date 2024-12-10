using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PrescriptionTemplate
{
    [Key]
    public long PrescriptionTemplateSer { get; set; }

    [StringLength(64)]
    public string PrescriptionTemplateName { get; set; } = null!;

    [StringLength(64)]
    public string PrescriptionName { get; set; } = null!;

    [StringLength(64)]
    public string? Intent { get; set; }

    [Column("UserCUID")]
    [StringLength(64)]
    public string? UserCuid { get; set; }

    [StringLength(32)]
    public string? Gating { get; set; }

    public int? SimulationNeeded { get; set; }

    [StringLength(64)]
    public string? BolusFrequency { get; set; }

    [StringLength(64)]
    public string? BolusThickness { get; set; }

    [StringLength(1024)]
    public string? Notes { get; set; }

    [StringLength(32)]
    public string Status { get; set; } = null!;

    [StringLength(16)]
    public string? PhaseType { get; set; }

    public int? NumberOfFractions { get; set; }

    [StringLength(64)]
    public string? Technique { get; set; }

    [StringLength(64)]
    public string? Site { get; set; }

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

    [InverseProperty("PrescriptionTemplateSerNavigation")]
    public virtual ICollection<Prescription> Prescription { get; set; } = new List<Prescription>();

    [InverseProperty("PrescriptionTemplateSerNavigation")]
    public virtual ICollection<PrescriptionTemplateAnatomy> PrescriptionTemplateAnatomy { get; set; } = new List<PrescriptionTemplateAnatomy>();

    [InverseProperty("PrescriptionTemplateSerNavigation")]
    public virtual ICollection<PrescriptionTemplateProperty> PrescriptionTemplateProperty { get; set; } = new List<PrescriptionTemplateProperty>();
}
