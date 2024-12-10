using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_app_parm_extended")]
public partial class IntfAppParmExtended
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("file_path")]
    [StringLength(80)]
    public string? FilePath { get; set; }

    [Column("rmot_drv_ind")]
    [StringLength(1)]
    public string? RmotDrvInd { get; set; }

    [Column("err_path")]
    [StringLength(80)]
    public string? ErrPath { get; set; }

    [Column("err_days")]
    public int? ErrDays { get; set; }

    [Column("bkup_ind")]
    [StringLength(1)]
    public string? BkupInd { get; set; }

    [Column("bkup_path")]
    [StringLength(80)]
    public string? BkupPath { get; set; }

    [Column("bkup_days")]
    public int? BkupDays { get; set; }

    [Column("bkup_ext_name")]
    [StringLength(3)]
    public string? BkupExtName { get; set; }

    [Column("file_no_gen_ind")]
    [StringLength(1)]
    public string? FileNoGenInd { get; set; }

    [Column("file_no_next_seq")]
    [StringLength(15)]
    public string? FileNoNextSeq { get; set; }

    [Column("file_no_start_val")]
    [StringLength(15)]
    public string? FileNoStartVal { get; set; }

    [Column("file_no_end_val")]
    [StringLength(15)]
    public string? FileNoEndVal { get; set; }

    [Column("file_no_prefix_list")]
    [StringLength(80)]
    public string? FileNoPrefixList { get; set; }

    [Column("file_no_cur_prefix")]
    [StringLength(10)]
    public string? FileNoCurPrefix { get; set; }

    [Column("file_no_ext_name")]
    [StringLength(3)]
    public string? FileNoExtName { get; set; }

    [Column("file_no_length")]
    public int? FileNoLength { get; set; }

    [Column("fac_id")]
    public int? FacId { get; set; }

    [Column("fac_inst_id")]
    [StringLength(30)]
    public string? FacInstId { get; set; }

    [Column("sni_pid_seg_no")]
    [StringLength(2)]
    public string? SniPidSegNo { get; set; }

    [Column("sni_pid_pos_in_seg")]
    public int? SniPidPosInSeg { get; set; }

    [Column("sni_pid_len")]
    public int? SniPidLen { get; set; }

    [Column("sni_pid_offset")]
    public int? SniPidOffset { get; set; }

    [Column("unsol_prcs_mthd")]
    [StringLength(1)]
    public string? UnsolPrcsMthd { get; set; }

    [Column("asc_ind")]
    [StringLength(11)]
    public string? AscInd { get; set; }

    [Column("prime_ind")]
    [StringLength(1)]
    public string? PrimeInd { get; set; }

    [Column("prime_id")]
    [StringLength(60)]
    public string? PrimeId { get; set; }

    [Column("spec_rule")]
    [StringLength(1)]
    public string? SpecRule { get; set; }

    [Column("store_uom_desc_ind")]
    [StringLength(1)]
    public string? StoreUomDescInd { get; set; }

    [Column("dflt_unsol_test_provider_ind")]
    [StringLength(1)]
    public string? DfltUnsolTestProviderInd { get; set; }

    [Column("auto_approve_ind")]
    [StringLength(1)]
    public string? AutoApproveInd { get; set; }

    [Column("gen_fac_rec_ind")]
    [StringLength(1)]
    public string? GenFacRecInd { get; set; }

    [Column("match_extrnl_pon")]
    [StringLength(1)]
    public string? MatchExtrnlPon { get; set; }

    [Column("prcs_with_no_results_ind")]
    [StringLength(1)]
    public string? PrcsWithNoResultsInd { get; set; }

    [Column("acct_provider_ind")]
    [StringLength(1)]
    public string? AcctProviderInd { get; set; }

    [Column("bill_prcs_mthd")]
    [StringLength(1)]
    public string? BillPrcsMthd { get; set; }

    [Column("bill_sys")]
    [StringLength(20)]
    public string? BillSys { get; set; }

    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string? BillSysInstId { get; set; }

    [Column("bill_max_detail_lines")]
    public int? BillMaxDetailLines { get; set; }

    [Column("bill_last_day_open_ind")]
    [StringLength(1)]
    public string? BillLastDayOpenInd { get; set; }

    [Column("bill_capitated_zero_ind")]
    [StringLength(1)]
    public string? BillCapitatedZeroInd { get; set; }

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

    [Column("rx_disc_new_ind")]
    [StringLength(1)]
    public string? RxDiscNewInd { get; set; }

    [Column("bill_charge_status_ind")]
    [StringLength(1)]
    public string? BillChargeStatusInd { get; set; }

    [Column("disp_loc_id")]
    public int? DispLocId { get; set; }

    [Column("lab_analyzer_ind")]
    [StringLength(1)]
    public string? LabAnalyzerInd { get; set; }

    [Column("lab_analyzer_send_comp_ind")]
    [StringLength(1)]
    public string? LabAnalyzerSendCompInd { get; set; }

    [Column("max_no_file_prcs")]
    public int? MaxNoFilePrcs { get; set; }

    [Column("read_only_ind")]
    [StringLength(1)]
    public string? ReadOnlyInd { get; set; }

    [Column("send_test_dx_ind")]
    [StringLength(1)]
    public string? SendTestDxInd { get; set; }

    [Column("auto_approve_abnormals_ind")]
    [StringLength(1)]
    public string? AutoApproveAbnormalsInd { get; set; }

    [Column("auto_approve_criticals_ind")]
    [StringLength(1)]
    public string? AutoApproveCriticalsInd { get; set; }

    [Column("gen_result_alerts_ind")]
    [StringLength(1)]
    public string? GenResultAlertsInd { get; set; }

    [Column("dcmnt_file_path")]
    [StringLength(80)]
    public string? DcmntFilePath { get; set; }

    [Column("pharm_order_send_ind")]
    [StringLength(1)]
    public string? PharmOrderSendInd { get; set; }

    [Column("pharm_order_appr_ind")]
    [StringLength(1)]
    public string? PharmOrderApprInd { get; set; }

    [Column("pharm_order_disp_ind")]
    [StringLength(1)]
    public string? PharmOrderDispInd { get; set; }

    [Column("select_first_name_rep_ind")]
    [StringLength(1)]
    public string? SelectFirstNameRepInd { get; set; }

    [Column("patient_table_name_rep_cd")]
    [StringLength(1)]
    public string? PatientTableNameRepCd { get; set; }

    [Column("hl7_rpt_ind")]
    [StringLength(1)]
    public string Hl7RptInd { get; set; } = null!;

    [Column("hl7_rpt_directory")]
    [StringLength(80)]
    public string? Hl7RptDirectory { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmExtended")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;
}
