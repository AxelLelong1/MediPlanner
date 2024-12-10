using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("WorkstationId", Name = "XAKWorkstation", IsUnique = true)]
public partial class Workstation
{
    [Key]
    public long WorkstationSer { get; set; }

    [StringLength(16)]
    public string WorkstationId { get; set; } = null!;

    [StringLength(64)]
    public string? WorkstationName { get; set; }

    [StringLength(64)]
    public string? Location { get; set; }

    [StringLength(64)]
    public string? ComputerName { get; set; }

    [StringLength(32)]
    public string? DefaultTask { get; set; }

    public long? QueueSelected { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("WorkstationSerNavigation")]
    public virtual ICollection<Machine> Machine { get; set; } = new List<Machine>();
}
