using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ResourceSer", "AddressSer")]
[Index("AddressSer", Name = "XIF680ResourceAddress")]
public partial class ResourceAddress
{
    [Key]
    public long ResourceSer { get; set; }

    [Key]
    public long AddressSer { get; set; }

    public long? CacheKeySer { get; set; }

    [Column("POCName")]
    [StringLength(254)]
    public string? Pocname { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddressSer")]
    [InverseProperty("ResourceAddress")]
    public virtual Address AddressSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("ResourceAddress")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
