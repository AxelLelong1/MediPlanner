using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TestId", "RevisionNo")]
[Table("test_mh")]
public partial class TestMh
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
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("test_inst_id")]
    [StringLength(30)]
    public string? TestInstId { get; set; }

    [Column("test_fac_id")]
    public int? TestFacId { get; set; }

    [Column("fac_rqstn_no")]
    [StringLength(20)]
    public string? FacRqstnNo { get; set; }

    [Column("prty_of_srv")]
    public int? PrtyOfSrv { get; set; }

    [Column("datetime_ordered", TypeName = "datetime")]
    public DateTime? DatetimeOrdered { get; set; }

    [Column("date_test_request", TypeName = "datetime")]
    public DateTime? DateTestRequest { get; set; }

    [Column("test_request_typ")]
    public int? TestRequestTyp { get; set; }

    [Column("perform_date_start", TypeName = "datetime")]
    public DateTime? PerformDateStart { get; set; }

    [Column("perform_date_end", TypeName = "datetime")]
    public DateTime? PerformDateEnd { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("order_vrbl_id")]
    public int? OrderVrblId { get; set; }

    [Column("no_prints")]
    public int? NoPrints { get; set; }

    [Column("sent_flag")]
    [StringLength(1)]
    public string? SentFlag { get; set; }

    [Column("send_status")]
    [StringLength(1)]
    public string? SendStatus { get; set; }

    [Column("rqstn_userid")]
    [StringLength(255)]
    public string? RqstnUserid { get; set; }

    [Column("rqstn_inst_id")]
    [StringLength(30)]
    public string? RqstnInstId { get; set; }

    [Column("print_rqstn_flag")]
    [StringLength(1)]
    public string? PrintRqstnFlag { get; set; }

    [Column("fac_rqstn_desc")]
    [StringLength(40)]
    public string? FacRqstnDesc { get; set; }

    [Column("include_spcmn")]
    [StringLength(1)]
    public string? IncludeSpcmn { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("intf_prcs_ind")]
    [StringLength(1)]
    public string? IntfPrcsInd { get; set; }

    [Column("ins_co_ind")]
    [StringLength(1)]
    public string? InsCoInd { get; set; }

    [Column("order_appr_ind")]
    [StringLength(1)]
    public string? OrderApprInd { get; set; }

    [Column("result_appr_ind")]
    [StringLength(1)]
    public string? ResultApprInd { get; set; }

    [Column("cancel_ind")]
    [StringLength(1)]
    public string? CancelInd { get; set; }

    [Column("audit_ind")]
    [StringLength(1)]
    public string? AuditInd { get; set; }

    [Column("order_cmt_ind")]
    [StringLength(1)]
    public string? OrderCmtInd { get; set; }

    [Column("test_cmt_ind")]
    [StringLength(1)]
    public string? TestCmtInd { get; set; }

    [Column("spcmn_collc_ind")]
    [StringLength(1)]
    public string? SpcmnCollcInd { get; set; }

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

    [Column("result_ind")]
    [StringLength(1)]
    public string? ResultInd { get; set; }

    [Column("asc_no")]
    [StringLength(15)]
    public string? AscNo { get; set; }

    [Column("asc_datetime", TypeName = "datetime")]
    public DateTime? AscDatetime { get; set; }

    [Column("partial_ind")]
    [StringLength(1)]
    public string? PartialInd { get; set; }

    [Column("cert_stkh_id")]
    [StringLength(20)]
    public string? CertStkhId { get; set; }

    [Column("bill_acct_id")]
    public int? BillAcctId { get; set; }

    [Column("producer_stkh_id")]
    [StringLength(20)]
    public string? ProducerStkhId { get; set; }

    [Column("gnrc_rqstn_ind")]
    [StringLength(1)]
    public string? GnrcRqstnInd { get; set; }

    [Column("read_only_ind")]
    [StringLength(1)]
    public string? ReadOnlyInd { get; set; }

    [Column("rqstn_stkh_id")]
    [StringLength(20)]
    public string? RqstnStkhId { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("vitals_ind")]
    [StringLength(30)]
    public string? VitalsInd { get; set; }

    [Column("account_billing_code_ser")]
    public long? AccountBillingCodeSer { get; set; }

    [Column("publish_ind")]
    [StringLength(1)]
    public string PublishInd { get; set; } = null!;

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }
}
