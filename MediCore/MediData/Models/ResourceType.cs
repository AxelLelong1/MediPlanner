using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceTypeCode", Name = "XAK1ResourceType", IsUnique = true)]
public partial class ResourceType
{
    [Key]
    public int ResourceTypeNum { get; set; }

    [StringLength(64)]
    public string ResourceTypeCode { get; set; } = null!;

    public int ExclusiveFlag { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ResourceTypeNumNavigation")]
    public virtual ICollection<ActtyCatgryResrcType> ActtyCatgryResrcType { get; set; } = new List<ActtyCatgryResrcType>();

    [InverseProperty("ResourceTypeNumNavigation")]
    public virtual ICollection<Resource> Resource { get; set; } = new List<Resource>();

    [InverseProperty("ResourceTypeNumNavigation")]
    public virtual ICollection<ResourceIdentifierType> ResourceIdentifierType { get; set; } = new List<ResourceIdentifierType>();
}
