using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", Name = "XIF899ResourceIdentifier")]
[Index("ResourceIdentifierTypeSer", Name = "XIF901ResourceIdentifier")]
public partial class ResourceIdentifier
{
    [Key]
    public long ResourceIdentifierSer { get; set; }

    public long ResourceSer { get; set; }

    public long ResourceIdentifierTypeSer { get; set; }

    [StringLength(30)]
    public string KeyValue { get; set; } = null!;

    [StringLength(30)]
    public string UpperKeyValue { get; set; } = null!;

    public int CurValueFlag { get; set; }

    public int ValidEntryFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ResourceIdentifierTypeSer")]
    [InverseProperty("ResourceIdentifier")]
    public virtual ResourceIdentifierType ResourceIdentifierTypeSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("ResourceIdentifier")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
