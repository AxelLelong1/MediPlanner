using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("CourseSer", Name = "XIF685PlanSum")]
[Index("ImageSer", Name = "XIF686PlanSum")]
public partial class PlanSum
{
    [Key]
    public long PlanSumSer { get; set; }

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string PlanSumId { get; set; } = null!;

    [StringLength(64)]
    public string? PlanSumName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? IsodoseLevels { get; set; }

    public int IsodoseLevelsLen { get; set; }

    public string? FieldRules { get; set; }

    public int FieldRulesLen { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? ImageSer { get; set; }

    [ForeignKey("CourseSer")]
    [InverseProperty("PlanSum")]
    public virtual Course CourseSerNavigation { get; set; } = null!;

    [InverseProperty("PlanSumSerNavigation")]
    public virtual ICollection<DoseObjectives> DoseObjectives { get; set; } = new List<DoseObjectives>();

    [InverseProperty("PlanSumSerNavigation")]
    public virtual ICollection<Dvh> Dvh { get; set; } = new List<Dvh>();

    [ForeignKey("ImageSer")]
    [InverseProperty("PlanSum")]
    public virtual Image1? ImageSerNavigation { get; set; }

    [InverseProperty("PlanSumSerNavigation")]
    public virtual ICollection<PlanSumPlanSetup> PlanSumPlanSetup { get; set; } = new List<PlanSumPlanSetup>();
}
