using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Rxcui", "Rxaui")]
[Table("RXNCONSO")]
[Index("Rxcui", Name = "nc1_RXNCONSO")]
[Index("Tty", Name = "nc2_RXNCONSO")]
[Index("Code", Name = "nc3_RXNCONSO")]
public partial class Rxnconso
{
    [Key]
    [Column("RXCUI")]
    [StringLength(8)]
    public string Rxcui { get; set; } = null!;

    [Column("LAT")]
    [StringLength(3)]
    public string Lat { get; set; } = null!;

    [Column("TS")]
    [StringLength(1)]
    public string? Ts { get; set; }

    [Column("LUI")]
    [StringLength(8)]
    public string? Lui { get; set; }

    [Column("STT")]
    [StringLength(3)]
    public string? Stt { get; set; }

    [Column("SUI")]
    [StringLength(8)]
    public string? Sui { get; set; }

    [Column("ISPREF")]
    [StringLength(1)]
    public string? Ispref { get; set; }

    [Key]
    [Column("RXAUI")]
    [StringLength(8)]
    public string Rxaui { get; set; } = null!;

    [Column("SAUI")]
    [StringLength(50)]
    public string? Saui { get; set; }

    [Column("SCUI")]
    [StringLength(50)]
    public string? Scui { get; set; }

    [Column("SDUI")]
    [StringLength(50)]
    public string? Sdui { get; set; }

    [Column("SAB")]
    [StringLength(20)]
    public string Sab { get; set; } = null!;

    [Column("TTY")]
    [StringLength(20)]
    public string Tty { get; set; } = null!;

    [Column("CODE")]
    [StringLength(50)]
    public string Code { get; set; } = null!;

    [Column("STR")]
    public string Str { get; set; } = null!;

    [Column("SRL")]
    [StringLength(10)]
    public string? Srl { get; set; }

    [Column("SUPPRESS")]
    [StringLength(1)]
    public string? Suppress { get; set; }

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
