using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class LookupMapping
{
    [Key]
    public long LookupMappingSer { get; set; }

    [StringLength(32)]
    public string ListSelector { get; set; } = null!;

    [StringLength(64)]
    public string ParentLookupValue { get; set; } = null!;

    [StringLength(64)]
    public string ChildLookupValue { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
