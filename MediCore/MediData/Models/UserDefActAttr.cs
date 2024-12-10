using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class UserDefActAttr
{
    [Key]
    public long UserDefActAttrSer { get; set; }

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

    [InverseProperty("UserDefActAttrSerNavigation")]
    public virtual ICollection<ActivityAttribute> ActivityAttribute { get; set; } = new List<ActivityAttribute>();

    [InverseProperty("UserDefActAttrSerNavigation")]
    public virtual ICollection<UserDefActAttrMh> UserDefActAttrMh { get; set; } = new List<UserDefActAttrMh>();

    [InverseProperty("UserDefActAttrSerNavigation")]
    public virtual ICollection<UserDefActAttrValue> UserDefActAttrValue { get; set; } = new List<UserDefActAttrValue>();
}
