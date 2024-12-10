using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PatientSer", "AddressSer")]
[Index("AddressSer", Name = "XIF665PatientAddress")]
public partial class PatientAddress
{
    [Key]
    public long PatientSer { get; set; }

    [Key]
    public long AddressSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddressSer")]
    [InverseProperty("PatientAddress")]
    public virtual Address AddressSerNavigation { get; set; } = null!;

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientAddress")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
