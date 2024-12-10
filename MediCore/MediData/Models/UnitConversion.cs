using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Source", "Destination")]
[Table("unit_conversion")]
public partial class UnitConversion
{
    [Key]
    [Column("source")]
    public int Source { get; set; }

    [Key]
    [Column("destination")]
    public int Destination { get; set; }

    [Column("conversion_id")]
    public int ConversionId { get; set; }

    [Column("multiplier", TypeName = "decimal(11, 4)")]
    public decimal? Multiplier { get; set; }

    [Column("formula")]
    [StringLength(255)]
    public string? Formula { get; set; }

    [Column("inverse_formula")]
    [StringLength(255)]
    public string? InverseFormula { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
