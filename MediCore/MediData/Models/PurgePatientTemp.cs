using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Index("Tablename", "Serialnumber1", "String161", Name = "XIE1PurgePatientTemp")]
public partial class PurgePatientTemp
{
    [StringLength(30)]
    public string Tablename { get; set; } = null!;

    public long? Serialnumber1 { get; set; }

    public long? Serialnumber2 { get; set; }

    public long? Serialnumber3 { get; set; }

    public int? Revisioncount1 { get; set; }

    public int? Revisioncount2 { get; set; }

    [StringLength(64)]
    public string? Uid1 { get; set; }

    public int? Int1 { get; set; }

    [Column("String16_1")]
    [StringLength(16)]
    public string? String161 { get; set; }

    [Column(TypeName = "numeric(7, 0)")]
    public decimal? Numeric1 { get; set; }
}
