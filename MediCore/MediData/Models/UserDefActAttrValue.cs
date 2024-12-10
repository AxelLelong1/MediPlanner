using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("UserDefActAttrSer", Name = "XIF660UserDefActAttrValue")]
public partial class UserDefActAttrValue
{
    [Key]
    public long UserDefActAttrValueSer { get; set; }

    public long UserDefActAttrSer { get; set; }

    public int UserDefActAttrRevCount { get; set; }

    [StringLength(254)]
    public string? AttributeValue { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("UserDefActAttrSer")]
    [InverseProperty("UserDefActAttrValue")]
    public virtual UserDefActAttr UserDefActAttrSerNavigation { get; set; } = null!;
}
