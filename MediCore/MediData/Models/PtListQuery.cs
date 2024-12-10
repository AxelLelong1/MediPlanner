using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_list_query")]
public partial class PtListQuery
{
    [Key]
    [Column("pt_list_query_id")]
    public int PtListQueryId { get; set; }

    [Column("pt_list_query_desc")]
    [StringLength(250)]
    public string PtListQueryDesc { get; set; } = null!;

    [Column("pt_list_query_typ")]
    public int PtListQueryTyp { get; set; }

    [Column("include_deceased_ind")]
    [StringLength(1)]
    public string IncludeDeceasedInd { get; set; } = null!;

    [Column("last_run_date", TypeName = "datetime")]
    public DateTime? LastRunDate { get; set; }

    [Column("last_run_userid")]
    [StringLength(255)]
    public string? LastRunUserid { get; set; }

    [Column("last_run_inst_id")]
    [StringLength(30)]
    public string? LastRunInstId { get; set; }

    [Column("last_run_elapsed_time")]
    public int? LastRunElapsedTime { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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

    [InverseProperty("PtListQuery")]
    public virtual ICollection<BaseTypPtListQueryXref> BaseTypPtListQueryXref { get; set; } = new List<BaseTypPtListQueryXref>();

    [InverseProperty("Query")]
    public virtual ICollection<PtClinicalNotificationCriteria> PtClinicalNotificationCriteria { get; set; } = new List<PtClinicalNotificationCriteria>();

    [InverseProperty("PtListQuery")]
    public virtual ICollection<PtListQueryCriteria> PtListQueryCriteria { get; set; } = new List<PtListQueryCriteria>();
}
