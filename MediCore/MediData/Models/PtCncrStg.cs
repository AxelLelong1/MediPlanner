using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtStageId")]
[Table("pt_cncr_stg")]
public partial class PtCncrStg
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_stage_id")]
    public int PtStageId { get; set; }

    [Column("cncr_stage")]
    [StringLength(20)]
    public string? CncrStage { get; set; }

    [Column("crit_desc")]
    [StringLength(40)]
    public string? CritDesc { get; set; }

    [Column("date_staged", TypeName = "datetime")]
    public DateTime? DateStaged { get; set; }

    [Column("staged_by_init")]
    [StringLength(5)]
    public string? StagedByInit { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("stage_basis")]
    [StringLength(1)]
    public string? StageBasis { get; set; }

    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Column("author_cd")]
    public int AuthorCd { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

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

    [Column("date_staged_cd")]
    public int? DateStagedCd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("stg_timing_typ")]
    public int? StgTimingTyp { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [InverseProperty("PtCncrStg")]
    public virtual ICollection<PtCncrStgCrit> PtCncrStgCrit { get; set; } = new List<PtCncrStgCrit>();

    [InverseProperty("PtCncrStg")]
    public virtual ICollection<XrefDxStg> XrefDxStg { get; set; } = new List<XrefDxStg>();
}
