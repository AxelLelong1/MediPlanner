using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAmdtId")]
[Table("pt_amdt")]
public partial class PtAmdt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_amdt_id")]
    public int PtAmdtId { get; set; }

    [Column("amdt_data")]
    [StringLength(255)]
    public string AmdtData { get; set; } = null!;

    [Column("amdt_rcvd_dt", TypeName = "datetime")]
    public DateTime AmdtRcvdDt { get; set; }

    [Column("amdt_dtl")]
    [StringLength(1000)]
    public string? AmdtDtl { get; set; }

    [Column("amdt_src_desc")]
    [StringLength(100)]
    public string? AmdtSrcDesc { get; set; }

    [Column("dispn_cd")]
    public int? DispnCd { get; set; }

    [Column("dispn_rationale")]
    [StringLength(1000)]
    public string? DispnRationale { get; set; }

    [Column("amdt_dispn_dt", TypeName = "datetime")]
    public DateTime? AmdtDispnDt { get; set; }

    [Column("amdt_chg_dt", TypeName = "datetime")]
    public DateTime? AmdtChgDt { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string ApprFlag { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("err_rsn_txt")]
    [StringLength(510)]
    public string? ErrRsnTxt { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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
}
