using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class Stage
{
    [Column("Stage")]
    [StringLength(32)]
    public string? Stage1 { get; set; }
}
