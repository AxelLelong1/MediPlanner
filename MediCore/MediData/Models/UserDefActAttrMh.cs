using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("UserDefActAttrSer", "UserDefActAttrRevCount")]
[Table("UserDefActAttrMH")]
public partial class UserDefActAttrMh
{
    [Key]
    public long UserDefActAttrSer { get; set; }

    [Key]
    public int UserDefActAttrRevCount { get; set; }

    [StringLength(16)]
    public string UserDefActAttrId { get; set; } = null!;

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("UserDefActAttrSer")]
    [InverseProperty("UserDefActAttrMh")]
    public virtual UserDefActAttr UserDefActAttrSerNavigation { get; set; } = null!;
}
