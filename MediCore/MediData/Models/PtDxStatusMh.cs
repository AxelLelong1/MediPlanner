using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DxStatusId", "RevisionNo")]
[Table("pt_dx_status_mh")]
public partial class PtDxStatusMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("dx_status_id")]
    public int DxStatusId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("asmt_date", TypeName = "datetime")]
    public DateTime? AsmtDate { get; set; }

    [Column("ps_author_1")]
    public int? PsAuthor1 { get; set; }

    [Column("ps_eff_date_1", TypeName = "datetime")]
    public DateTime? PsEffDate1 { get; set; }

    [Column("perf_status_1")]
    public int? PerfStatus1 { get; set; }

    [Column("ps_author_2")]
    public int? PsAuthor2 { get; set; }

    [Column("ps_eff_date_2", TypeName = "datetime")]
    public DateTime? PsEffDate2 { get; set; }

    [Column("perf_status_2")]
    public int? PerfStatus2 { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("impr_desc")]
    [StringLength(255)]
    public string? ImprDesc { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }
}
