using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Index("Spid", "ContextName", "AttributeName", Name = "PK_AppContext", IsUnique = true)]
public partial class AppContext
{
    [Column("spid")]
    public int? Spid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ContextName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AttributeName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AttributeValue { get; set; }
}
