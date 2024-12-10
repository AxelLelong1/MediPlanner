using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RXNATOMARCHIVE")]
[Index("Rxaui", Name = "nc1_RXNATOMARCHIVE")]
[Index("Rxcui", Name = "nc2_RXNATOMARCHIVE")]
[Index("MergedToRxcui", Name = "nc3_RXNATOMARCHIVE")]
public partial class Rxnatomarchive
{
    [Key]
    [Column("RXNATOMARCHIVE_ID")]
    public int RxnatomarchiveId { get; set; }

    [Column("RXAUI")]
    [StringLength(8)]
    public string Rxaui { get; set; } = null!;

    [Column("AUI")]
    [StringLength(10)]
    public string? Aui { get; set; }

    [Column("STR")]
    [StringLength(4000)]
    public string Str { get; set; } = null!;

    [Column("ARCHIVE_TIMESTAMP")]
    [StringLength(280)]
    public string ArchiveTimestamp { get; set; } = null!;

    [Column("CREATED_TIMESTAMP")]
    [StringLength(280)]
    public string CreatedTimestamp { get; set; } = null!;

    [Column("UPDATED_TIMESTAMP")]
    [StringLength(280)]
    public string UpdatedTimestamp { get; set; } = null!;

    [Column("CODE")]
    [StringLength(10)]
    public string? Code { get; set; }

    [Column("IS_BRAND")]
    [StringLength(1)]
    public string? IsBrand { get; set; }

    [Column("LAT")]
    [StringLength(3)]
    public string? Lat { get; set; }

    [Column("LAST_RELEASED")]
    [StringLength(30)]
    public string? LastReleased { get; set; }

    [Column("SAUI")]
    [StringLength(20)]
    public string? Saui { get; set; }

    [Column("VSAB")]
    [StringLength(40)]
    public string? Vsab { get; set; }

    [Column("RXCUI")]
    [StringLength(8)]
    public string? Rxcui { get; set; }

    [Column("SAB")]
    [StringLength(20)]
    public string? Sab { get; set; }

    [Column("TTY")]
    [StringLength(20)]
    public string? Tty { get; set; }

    [Column("MERGED_TO_RXCUI")]
    [StringLength(8)]
    public string? MergedToRxcui { get; set; }

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
