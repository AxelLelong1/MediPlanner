using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Rxaui", "OldRxcui", "NewRxcui")]
[Table("RXNCUICHANGES")]
public partial class Rxncuichanges
{
    [Key]
    [Column("RXAUI")]
    [StringLength(8)]
    public string Rxaui { get; set; } = null!;

    [Column("CODE")]
    [StringLength(50)]
    public string? Code { get; set; }

    [Column("SAB")]
    [StringLength(20)]
    public string? Sab { get; set; }

    [Column("TTY")]
    [StringLength(20)]
    public string? Tty { get; set; }

    [Column("STR")]
    [StringLength(3000)]
    public string? Str { get; set; }

    [Key]
    [Column("OLD_RXCUI")]
    [StringLength(8)]
    public string OldRxcui { get; set; } = null!;

    [Key]
    [Column("NEW_RXCUI")]
    [StringLength(8)]
    public string NewRxcui { get; set; } = null!;

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
