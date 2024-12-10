using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RXNSATOCD")]
[Index("Rxcui", Name = "nc1_RXNSATOCD")]
[Index("Atn", Name = "nc2_RXNSATOCD")]
public partial class Rxnsatocd
{
    [Key]
    [Column("RXNSATOCD_ID")]
    public int RxnsatocdId { get; set; }

    [Column("RXCUI")]
    [StringLength(8)]
    public string Rxcui { get; set; } = null!;

    [Column("LUI")]
    [StringLength(8)]
    public string? Lui { get; set; }

    [Column("SUI")]
    [StringLength(8)]
    public string? Sui { get; set; }

    [Column("RXAUI")]
    [StringLength(8)]
    public string? Rxaui { get; set; }

    [Column("STYPE")]
    [StringLength(50)]
    public string? Stype { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    public string? Code { get; set; }

    [Column("ATUI")]
    [StringLength(11)]
    public string? Atui { get; set; }

    [Column("SATUI")]
    [StringLength(50)]
    public string? Satui { get; set; }

    [Column("ATN")]
    [StringLength(50)]
    public string Atn { get; set; } = null!;

    [Column("SAB")]
    [StringLength(20)]
    public string Sab { get; set; } = null!;

    [Column("ATV")]
    [StringLength(4000)]
    public string? Atv { get; set; }

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
