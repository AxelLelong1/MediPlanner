using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "SyncSeqNo", "TblName")]
[Table("trf_sync_det")]
public partial class TrfSyncDet
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

    [Key]
    [Column("tbl_name")]
    [StringLength(30)]
    public string TblName { get; set; } = null!;

    [Column("compl_flag")]
    [StringLength(1)]
    public string ComplFlag { get; set; } = null!;

    [Column("rec_read")]
    public int RecRead { get; set; }

    [Column("rec_del")]
    public int RecDel { get; set; }

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

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [ForeignKey("InstId, TrfDirctn, SyncSeqNo")]
    [InverseProperty("TrfSyncDet")]
    public virtual TrfSync TrfSync { get; set; } = null!;
}
