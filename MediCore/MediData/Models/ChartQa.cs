using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ChartQA")]
[Index("PatientSer", Name = "XIF792ChartQA")]
[Index("ActivityInstanceSer", Name = "XIF793ChartQA")]
public partial class ChartQa
{
    [Key]
    [Column("ChartQASer")]
    public long ChartQaser { get; set; }

    public long PatientSer { get; set; }

    [Column("ChartQADateTime", TypeName = "datetime")]
    public DateTime ChartQadateTime { get; set; }

    [Column("ChartQABy")]
    [StringLength(255)]
    public string ChartQaby { get; set; } = null!;

    [StringLength(1024)]
    public string? Comment { get; set; }

    public long? ActivityInstanceSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ChartQa")]
    public virtual ActivityInstance? ActivityInstanceSerNavigation { get; set; }

    [InverseProperty("ChartQaserNavigation")]
    public virtual ICollection<ChartQatreatment> ChartQatreatment { get; set; } = new List<ChartQatreatment>();

    [ForeignKey("PatientSer")]
    [InverseProperty("ChartQa")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
