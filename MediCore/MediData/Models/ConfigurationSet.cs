using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ConfigurationSetId", Name = "XIE1ConfigurationSet")]
[Index("AppUserSer", Name = "XIF360ConfigurationSet")]
[Index("DepartmentSer", Name = "XIF365ConfigurationSet")]
public partial class ConfigurationSet
{
    [Key]
    public long ConfigurationSetSer { get; set; }

    public long? DepartmentSer { get; set; }

    public long? AppUserSer { get; set; }

    [StringLength(16)]
    public string ConfigurationSetId { get; set; } = null!;

    public int UserOverrideFlag { get; set; }

    public int EditFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AppUserSer")]
    [InverseProperty("ConfigurationSet")]
    public virtual AppUser? AppUserSerNavigation { get; set; }

    [InverseProperty("ConfigurationSetSerNavigation")]
    public virtual ICollection<ConfigurationItem> ConfigurationItem { get; set; } = new List<ConfigurationItem>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ConfigurationSet")]
    public virtual Department? DepartmentSerNavigation { get; set; }
}
