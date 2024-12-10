using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TestId", "TestResultGroupId", "TestResultId")]
[Table("test_result")]
[Index("TypOfTest", "CompName", "TransLogTstamp", Name = "nc1_test_result")]
[Index("TypOfTest", "CompName", "DateTestPtTest", Name = "nc2_test_result")]
[Index("PtId", "TestId", "ValidEntryInd", Name = "nc3_test_result")]
public partial class TestResult
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("test_id")]
    public int TestId { get; set; }

    [Key]
    [Column("test_result_group_id")]
    public int TestResultGroupId { get; set; }

    [Key]
    [Column("test_result_id")]
    public int TestResultId { get; set; }

    [Column("symbol_cd")]
    [StringLength(3)]
    public string? SymbolCd { get; set; }

    [Column("comp_typ")]
    public int CompTyp { get; set; }

    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("fac_comp_name")]
    [StringLength(30)]
    public string FacCompName { get; set; } = null!;

    [Column("comp_sub_id")]
    [StringLength(10)]
    public string? CompSubId { get; set; }

    [Column("test_value", TypeName = "numeric(11, 4)")]
    public decimal? TestValue { get; set; }

    [Column("test_value_string")]
    [StringLength(255)]
    public string? TestValueString { get; set; }

    [Column("test_value_txt_ind")]
    [StringLength(1)]
    public string? TestValueTxtInd { get; set; }

    [Column("test_value_txt")]
    public string? TestValueTxt { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }

    [Column("test_value_status_cd")]
    [StringLength(1)]
    public string? TestValueStatusCd { get; set; }

    [Column("min_norm", TypeName = "numeric(11, 4)")]
    public decimal? MinNorm { get; set; }

    [Column("max_norm", TypeName = "numeric(11, 4)")]
    public decimal? MaxNorm { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("unit_desc")]
    [StringLength(40)]
    public string? UnitDesc { get; set; }

    [Column("comp_order_no")]
    public int? CompOrderNo { get; set; }

    [Column("date_test_pt_test", TypeName = "datetime")]
    public DateTime? DateTestPtTest { get; set; }

    [Column("req_flag")]
    [StringLength(1)]
    public string? ReqFlag { get; set; }

    [Column("rule_ind")]
    [StringLength(1)]
    public string? RuleInd { get; set; }

    [Column("this_visit_req_ind")]
    [StringLength(1)]
    public string? ThisVisitReqInd { get; set; }

    [Column("unsol_ind")]
    [StringLength(1)]
    public string? UnsolInd { get; set; }

    [Column("min_reason", TypeName = "numeric(11, 4)")]
    public decimal? MinReason { get; set; }

    [Column("max_reason", TypeName = "numeric(11, 4)")]
    public decimal? MaxReason { get; set; }

    [Column("calc_typ")]
    public int? CalcTyp { get; set; }

    [Column("calc_reltn_cd")]
    [StringLength(1)]
    public string? CalcReltnCd { get; set; }

    [Column("calc_group")]
    public int? CalcGroup { get; set; }

    [Column("dose_calc_ind")]
    [StringLength(1)]
    public string? DoseCalcInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("audit_ind")]
    [StringLength(1)]
    public string? AuditInd { get; set; }

    [Column("result_appr_ind")]
    [StringLength(1)]
    public string? ResultApprInd { get; set; }

    [Column("result_ind")]
    [StringLength(1)]
    public string? ResultInd { get; set; }

    [Column("result_cmt_ind")]
    [StringLength(1)]
    public string? ResultCmtInd { get; set; }

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

    [Column("calc_prcs_cd")]
    [StringLength(1)]
    public string? CalcPrcsCd { get; set; }

    [Column("producer_stkh_id")]
    [StringLength(20)]
    public string? ProducerStkhId { get; set; }

    [Column("corrected_entry_ind")]
    [StringLength(1)]
    public string? CorrectedEntryInd { get; set; }

    [Column("alert_ind")]
    [StringLength(1)]
    public string? AlertInd { get; set; }

    [Column("alert_auto_ind")]
    [StringLength(1)]
    public string? AlertAutoInd { get; set; }

    [Column("alert_hx_ind")]
    [StringLength(1)]
    public string? AlertHxInd { get; set; }

    [Column("abnormal_flag_cd")]
    [StringLength(5)]
    public string? AbnormalFlagCd { get; set; }

    [Column("read_only_ind")]
    [StringLength(1)]
    public string? ReadOnlyInd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("dsp_ref_range")]
    [StringLength(20)]
    public string? DspRefRange { get; set; }

    [Column("dsp_ref_range_uninterp_ind")]
    [StringLength(1)]
    public string? DspRefRangeUninterpInd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("min_abs", TypeName = "numeric(11, 4)")]
    public decimal? MinAbs { get; set; }

    [Column("max_abs", TypeName = "numeric(11, 4)")]
    public decimal? MaxAbs { get; set; }

    [Column("loinc_cd")]
    [StringLength(10)]
    public string? LoincCd { get; set; }

    [Column("publish_ind")]
    [StringLength(1)]
    public string PublishInd { get; set; } = null!;

    [ForeignKey("CalcTyp")]
    [InverseProperty("TestResult")]
    public virtual CalcTyp? CalcTypNavigation { get; set; }

    [ForeignKey("SymbolCd")]
    [InverseProperty("TestResult")]
    public virtual SymbolCd? SymbolCdNavigation { get; set; }
}
