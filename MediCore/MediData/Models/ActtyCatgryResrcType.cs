using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceTypeNum", "ActivityCategorySer", Name = "XAK1EventTypeResourceType", IsUnique = true)]
[Index("ActivityCategorySer", Name = "XIF273EventTypeResourceType")]
public partial class ActtyCatgryResrcType
{
    [Key]
    public long ActtyCatgryResrcTypeSer { get; set; }

    public long ActivityCategorySer { get; set; }

    public int ResourceTypeNum { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityCategorySer")]
    [InverseProperty("ActtyCatgryResrcType")]
    public virtual ActivityCategory ActivityCategorySerNavigation { get; set; } = null!;

    [ForeignKey("ResourceTypeNum")]
    [InverseProperty("ActtyCatgryResrcType")]
    public virtual ResourceType ResourceTypeNumNavigation { get; set; } = null!;
}
