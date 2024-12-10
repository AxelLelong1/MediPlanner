using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("VolOptStructSer", Name = "XIF498VolOptStructCstr")]
public partial class VolOptStructCstr
{
    [Key]
    public long VolOptStructCstrSer { get; set; }

    public long VolOptStructSer { get; set; }

    [StringLength(16)]
    public string VolOptStructCstrId { get; set; } = null!;

    [StringLength(64)]
    public string? VolOptStructCstrName { get; set; }

    public string? Parameters { get; set; }

    public int ParametersLen { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("VolOptStructSer")]
    [InverseProperty("VolOptStructCstr")]
    public virtual VolOptStruct VolOptStructSerNavigation { get; set; } = null!;
}
