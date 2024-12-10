using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillSysInstId", "BillSysId")]
[Table("bill_system")]
public partial class BillSystem
{
    [Key]
    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string BillSysInstId { get; set; } = null!;

    [Key]
    [Column("bill_sys_id")]
    [StringLength(20)]
    public string BillSysId { get; set; } = null!;

    [Column("bill_sys_desc")]
    [StringLength(255)]
    public string? BillSysDesc { get; set; }

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

    [Column("override_batch_ind")]
    [StringLength(1)]
    public string? OverrideBatchInd { get; set; }

    [Column("bill_all_cd_ind")]
    [StringLength(1)]
    public string? BillAllCdInd { get; set; }

    [Column("bill_cd_eff_dt", TypeName = "datetime")]
    public DateTime? BillCdEffDt { get; set; }

    [Column("bill_days_delay")]
    public int? BillDaysDelay { get; set; }

    [Column("trans_posting_date", TypeName = "datetime")]
    public DateTime? TransPostingDate { get; set; }

    [Column("gen_filler_ref_ind")]
    [StringLength(1)]
    public string? GenFillerRefInd { get; set; }

    [Column("bill_acct_ind")]
    [StringLength(1)]
    public string? BillAcctInd { get; set; }

    [Column("bill_rpt_sort_order_1")]
    [StringLength(1)]
    public string? BillRptSortOrder1 { get; set; }

    [Column("bill_rpt_sort_order_2")]
    [StringLength(1)]
    public string? BillRptSortOrder2 { get; set; }

    [Column("bill_rpt_sort_order_3")]
    [StringLength(1)]
    public string? BillRptSortOrder3 { get; set; }

    [Column("bill_spsr_cd")]
    [StringLength(1)]
    public string? BillSpsrCd { get; set; }

    [Column("offset_date", TypeName = "datetime")]
    public DateTime? OffsetDate { get; set; }

    [Column("bill_sys_typ_cd")]
    [StringLength(1)]
    public string? BillSysTypCd { get; set; }

    [Column("enable_batch_setup_ind")]
    [StringLength(1)]
    public string? EnableBatchSetupInd { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string? IntfAppParmId { get; set; }

    [Column("merge_ind")]
    [StringLength(1)]
    public string? MergeInd { get; set; }

    [Column("ace_ind")]
    [StringLength(1)]
    public string? AceInd { get; set; }

    [Column("ace_out_typ")]
    [StringLength(1)]
    public string? AceOutTyp { get; set; }

    [Column("ace_dt_format")]
    [StringLength(32)]
    public string? AceDtFormat { get; set; }

    [Column("ace_field_delimiter")]
    [StringLength(1)]
    public string? AceFieldDelimiter { get; set; }

    [Column("ace_txt_delimiter")]
    [StringLength(1)]
    public string? AceTxtDelimiter { get; set; }

    [Column("ace_file_typ")]
    [StringLength(1)]
    public string? AceFileTyp { get; set; }

    [Column("ace_include_col_hdr_ind")]
    [StringLength(1)]
    public string? AceIncludeColHdrInd { get; set; }

    [Column("suppress_amt_ind")]
    [StringLength(1)]
    public string? SuppressAmtInd { get; set; }

    [InverseProperty("BillSystem")]
    public virtual ICollection<BillEvntChrgWrk> BillEvntChrgWrk { get; set; } = new List<BillEvntChrgWrk>();

    [InverseProperty("BillSystem")]
    public virtual ICollection<BillSysBatchSetup> BillSysBatchSetup { get; set; } = new List<BillSysBatchSetup>();

    [InverseProperty("BillSystem")]
    public virtual ICollection<InstBillCdInfo> InstBillCdInfo { get; set; } = new List<InstBillCdInfo>();
}
