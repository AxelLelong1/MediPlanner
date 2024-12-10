using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "TrfFnctn", "TrfTstamp")]
[Table("trf_log")]
public partial class TrfLog
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
    [Column("trf_fnctn")]
    [StringLength(30)]
    public string TrfFnctn { get; set; } = null!;

    [Key]
    [Column("trf_tstamp", TypeName = "datetime")]
    public DateTime TrfTstamp { get; set; }

    [Column("rec_count")]
    public int RecCount { get; set; }

    [Column("rec_committed")]
    public int RecCommitted { get; set; }

    [Column("file_ext_seq_no")]
    public int FileExtSeqNo { get; set; }

    [Column("compl_flag")]
    [StringLength(1)]
    public string ComplFlag { get; set; } = null!;

    [Column("start_tstamp", TypeName = "datetime")]
    public DateTime? StartTstamp { get; set; }

    [Column("stop_tstamp", TypeName = "datetime")]
    public DateTime? StopTstamp { get; set; }

    [Column("files_processed")]
    public int? FilesProcessed { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("void_ind")]
    [StringLength(1)]
    public string? VoidInd { get; set; }

    [Column("ovride_tstamp", TypeName = "datetime")]
    public DateTime? OvrideTstamp { get; set; }

    [ForeignKey("InstId, TrfDirctn")]
    [InverseProperty("TrfLog")]
    public virtual TrfInst TrfInst { get; set; } = null!;
}
