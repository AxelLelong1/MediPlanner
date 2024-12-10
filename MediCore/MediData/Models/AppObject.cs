using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ObjectName", "ObjectGroupName", Name = "XAK1ScreenObject", IsUnique = true)]
[Index("ObjectGroupName", Name = "XIE1AppObject")]
public partial class AppObject
{
    [Key]
    public long AppObjectSer { get; set; }

    [StringLength(64)]
    public string ObjectName { get; set; } = null!;

    [StringLength(64)]
    public string ObjectGroupName { get; set; } = null!;

    [StringLength(64)]
    public string? Description { get; set; }

    public int AddStatusFlag { get; set; }

    public int DeleteStatusFlag { get; set; }

    public int ApproveStatusFlag { get; set; }

    public int AccessStatusFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
