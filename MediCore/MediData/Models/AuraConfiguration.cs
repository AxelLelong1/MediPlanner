using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("AuraConfiguration", Schema = "DWH")]
public partial class AuraConfiguration
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(32)]
    public string? Key { get; set; }

    [StringLength(1024)]
    public string? KeyValue { get; set; }
}
