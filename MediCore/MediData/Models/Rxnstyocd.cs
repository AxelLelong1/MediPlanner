using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Rxcui", "Tui")]
[Table("RXNSTYOCD")]
public partial class Rxnstyocd
{
    [Key]
    [Column("RXCUI")]
    [StringLength(8)]
    public string Rxcui { get; set; } = null!;

    [Key]
    [Column("TUI")]
    [StringLength(4)]
    public string Tui { get; set; } = null!;

    [Column("STN")]
    [StringLength(100)]
    public string? Stn { get; set; }

    [Column("STY")]
    [StringLength(50)]
    public string? Sty { get; set; }

    [Column("ATUI")]
    [StringLength(11)]
    public string? Atui { get; set; }

    [Column("CVF")]
    [StringLength(50)]
    public string? Cvf { get; set; }

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
