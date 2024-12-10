using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "SyncSeqNo")]
[Table("trf_sync")]
public partial class TrfSync
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Key]
    [Column("sync_seq_no")]
    public int SyncSeqNo { get; set; }

    [Column("sql_clause")]
    [StringLength(255)]
    public string? SqlClause { get; set; }

    [Column("dbms")]
    [StringLength(30)]
    public string Dbms { get; set; } = null!;

    [Column("server_name")]
    [StringLength(30)]
    public string ServerName { get; set; } = null!;

    [Column("db_name")]
    [StringLength(30)]
    public string DbName { get; set; } = null!;

    [Column("stop_tstamp", TypeName = "datetime")]
    public DateTime StopTstamp { get; set; }

    [Column("resp_ind")]
    [StringLength(1)]
    public string RespInd { get; set; } = null!;

    [Column("compl_flag")]
    [StringLength(1)]
    public string ComplFlag { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("sync_tstamp", TypeName = "datetime")]
    public DateTime? SyncTstamp { get; set; }

    [Column("from_tstamp", TypeName = "datetime")]
    public DateTime? FromTstamp { get; set; }

    [ForeignKey("InstId, TrfDirctn")]
    [InverseProperty("TrfSync")]
    public virtual TrfInst TrfInst { get; set; } = null!;

    [InverseProperty("TrfSync")]
    public virtual ICollection<TrfSyncDet> TrfSyncDet { get; set; } = new List<TrfSyncDet>();
}
