using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CodeValue", "CodeType")]
public partial class ResourceIdentifierCode
{
    [Key]
    [StringLength(6)]
    public string CodeValue { get; set; } = null!;

    [Key]
    public int CodeType { get; set; }

    [StringLength(60)]
    public string? CodeDesc { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
