using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceTypeNum", Name = "XIF900ResourceIdentifierType")]
public partial class ResourceIdentifierType
{
    [Key]
    public long ResourceIdentifierTypeSer { get; set; }

    public int ResourceTypeNum { get; set; }

    [StringLength(100)]
    public string ResourceDescription { get; set; } = null!;

    public int ActiveFlag { get; set; }

    public int RequiredFlag { get; set; }

    public int UniqueFlag { get; set; }

    public int UniqueHistoryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? CodeType { get; set; }

    [Column("SSCodeValue")]
    [StringLength(6)]
    public string? SscodeValue { get; set; }

    [InverseProperty("ResourceIdentifierTypeSerNavigation")]
    public virtual ICollection<ResourceIdentifier> ResourceIdentifier { get; set; } = new List<ResourceIdentifier>();

    [ForeignKey("ResourceTypeNum")]
    [InverseProperty("ResourceIdentifierType")]
    public virtual ResourceType ResourceTypeNumNavigation { get; set; } = null!;
}
