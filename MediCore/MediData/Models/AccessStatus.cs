using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", Name = "XIF478AccessStatus")]
public partial class AccessStatus
{
    [Key]
    public long AccessStatusSer { get; set; }

    public long PatientSer { get; set; }

    public byte[]? TimeStamp { get; set; }

    [StringLength(32)]
    public string TypeOfTimeStamp { get; set; } = null!;

    [StringLength(255)]
    public string? UserName { get; set; }

    [StringLength(32)]
    public string? TaskName { get; set; }

    [StringLength(64)]
    public string? WorkStationName { get; set; }

    public int? ExtModified { get; set; }

    [StringLength(32)]
    public string? ExtTaskName { get; set; }

    [StringLength(255)]
    public string? ExtUserName { get; set; }

    [StringLength(64)]
    public string? ExtWorkstation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("AccessStatus")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
