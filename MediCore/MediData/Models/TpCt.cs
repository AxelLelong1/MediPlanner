using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo")]
[Table("tp_ct")]
public partial class TpCt
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("ct_phase_cd")]
    public int? CtPhaseCd { get; set; }

    [Column("tp_category_cmt")]
    [StringLength(255)]
    public string? TpCategoryCmt { get; set; }

    [Column("ct_subj_cd")]
    public int? CtSubjCd { get; set; }

    [Column("pdq_no")]
    [StringLength(30)]
    public string? PdqNo { get; set; }

    [Column("tp_authorship_cd")]
    public int? TpAuthorshipCd { get; set; }

    [Column("tp_category_cd")]
    public int? TpCategoryCd { get; set; }

    [Column("tp_holder_cd")]
    public int? TpHolderCd { get; set; }

    [Column("tp_crref_cd")]
    public int? TpCrrefCd { get; set; }

    [Column("tp_binder")]
    public int? TpBinder { get; set; }

    [Column("accrual_typ")]
    public int? AccrualTyp { get; set; }

    [Column("tp_accrual_grade_cd")]
    public int? TpAccrualGradeCd { get; set; }

    [Column("tp_nci_program_cd")]
    public int? TpNciProgramCd { get; set; }

    [Column("tp_std_of_care_ind")]
    [StringLength(1)]
    public string? TpStdOfCareInd { get; set; }

    [Column("tp_tissue_access_ind")]
    [StringLength(1)]
    public string? TpTissueAccessInd { get; set; }

    [Column("tp_phi_release_cd")]
    public int? TpPhiReleaseCd { get; set; }

    [Column("agt_dev_ind")]
    [StringLength(1)]
    public string? AgtDevInd { get; set; }

    [Column("mng_by_typ")]
    public int? MngByTyp { get; set; }

    [Column("tp_category_typ")]
    public int? TpCategoryTyp { get; set; }

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

    [Column("export_ct_ind")]
    [StringLength(1)]
    public string? ExportCtInd { get; set; }

    [Column("study_mat_moved_ind")]
    [StringLength(1)]
    public string? StudyMatMovedInd { get; set; }

    [Column("pt_mat_moved_ind")]
    [StringLength(1)]
    public string? PtMatMovedInd { get; set; }

    [Column("activation_ready_date", TypeName = "datetime")]
    public DateTime? ActivationReadyDate { get; set; }
}
