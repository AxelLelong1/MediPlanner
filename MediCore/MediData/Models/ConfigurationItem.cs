using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ConfigurationSetSer", "ConfigurationItemId")]
[Index("ConfigurationItemId", Name = "XIE1ConfigurationItem")]
public partial class ConfigurationItem
{
    [Key]
    public long ConfigurationSetSer { get; set; }

    [Key]
    [StringLength(64)]
    public string ConfigurationItemId { get; set; } = null!;

    [StringLength(254)]
    public string? ConfigValue { get; set; }

    [Column("SettingXML")]
    public string? SettingXml { get; set; }

    [Column("SettingXMLLen")]
    public int SettingXmllen { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ConfigurationSetSer")]
    [InverseProperty("ConfigurationItem")]
    public virtual ConfigurationSet ConfigurationSetSerNavigation { get; set; } = null!;
}
