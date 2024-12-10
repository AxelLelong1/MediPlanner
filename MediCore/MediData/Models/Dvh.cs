using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DVH")]
[Index("PlanSetupSer", Name = "XIF707DVH")]
[Index("PlanSumSer", Name = "XIF736DVH")]
public partial class Dvh
{
    [Key]
    [Column("DVHSer")]
    public long Dvhser { get; set; }

    public long? PlanSumSer { get; set; }

    public long? PlanSetupSer { get; set; }

    public string? Structures { get; set; }

    public int StructuresLen { get; set; }

    [Column("DVHDisplayFlags")]
    public int? DvhdisplayFlags { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("Dvh")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [ForeignKey("PlanSumSer")]
    [InverseProperty("Dvh")]
    public virtual PlanSum? PlanSumSerNavigation { get; set; }
}
