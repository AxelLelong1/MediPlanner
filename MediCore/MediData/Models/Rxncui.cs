using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Cui1", "Cui2")]
[Table("RXNCUI")]
public partial class Rxncui
{
    [Key]
    [Column("cui1")]
    [StringLength(8)]
    public string Cui1 { get; set; } = null!;

    [Column("ver_start")]
    [StringLength(20)]
    public string? VerStart { get; set; }

    [Column("ver_end")]
    [StringLength(20)]
    public string? VerEnd { get; set; }

    [Column("cardinality")]
    [StringLength(8)]
    public string? Cardinality { get; set; }

    [Key]
    [Column("cui2")]
    [StringLength(8)]
    public string Cui2 { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
