using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "VrblId")]
[Table("vrbl_order")]
[Index("VrblInstId", "VrblUserid", "TransLogTstamp", Name = "nc1_vrbl_order")]
[Index("VrblInstId", "TransLogUserid", Name = "nc2_vrbl_order")]
[Index("TransLogInstId", "TransLogUserid", "TransLogTstamp", Name = "nc3_vrbl_order")]
[Index("OrderTyp", Name = "nc4_vrbl_order")]
[Index("VrblTstamp", Name = "nc5_vrbl_order")]
[Index("TransLogInstId", "TransLogUserid", "VrblTstamp", Name = "nc6_vrbl_order")]
[Index("InstId", "CompletedInd", "AppliedInd", "ValidEntryInd", "GeneratedInd", Name = "nc9_vrbl_order")]
public partial class VrblOrder
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("vrbl_id")]
    public int VrblId { get; set; }

    [Column("vrbl_userid")]
    [StringLength(255)]
    public string VrblUserid { get; set; } = null!;

    [Column("vrbl_inst_id")]
    [StringLength(30)]
    public string VrblInstId { get; set; } = null!;

    [Column("vrbl_tstamp", TypeName = "datetime")]
    public DateTime VrblTstamp { get; set; }

    [Column("vrbl_txt")]
    public string? VrblTxt { get; set; }

    [Column("vrbl_appr_tstamp", TypeName = "datetime")]
    public DateTime? VrblApprTstamp { get; set; }

    [Column("vrbl_appr_txt")]
    public string? VrblApprTxt { get; set; }

    [Column("vrbl_appr_flag")]
    [StringLength(1)]
    public string VrblApprFlag { get; set; } = null!;

    [Column("vrbl_typ")]
    [StringLength(1)]
    public string VrblTyp { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("applied_ind")]
    [StringLength(1)]
    public string? AppliedInd { get; set; }

    [Column("applied_txt")]
    public string? AppliedTxt { get; set; }

    [Column("applied_tstamp", TypeName = "datetime")]
    public DateTime? AppliedTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("vrbl_source_typ")]
    [StringLength(1)]
    public string? VrblSourceTyp { get; set; }

    [Column("pln_affect_ind")]
    [StringLength(1)]
    public string? PlnAffectInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("applied_inst_id")]
    [StringLength(30)]
    public string? AppliedInstId { get; set; }

    [Column("applied_userid")]
    [StringLength(255)]
    public string? AppliedUserid { get; set; }

    [Column("error_desc")]
    [StringLength(255)]
    public string? ErrorDesc { get; set; }

    [Column("error_userid")]
    [StringLength(255)]
    public string? ErrorUserid { get; set; }

    [Column("error_tstamp", TypeName = "datetime")]
    public DateTime? ErrorTstamp { get; set; }

    [Column("error_inst_id")]
    [StringLength(30)]
    public string? ErrorInstId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("generated_ind")]
    [StringLength(1)]
    public string? GeneratedInd { get; set; }

    [Column("completed_ind")]
    [StringLength(1)]
    public string? CompletedInd { get; set; }

    [Column("placer_order_no")]
    [StringLength(20)]
    public string? PlacerOrderNo { get; set; }

    [Column("hx_ind")]
    [StringLength(1)]
    public string? HxInd { get; set; }

    [Column("appr_on_file_ind")]
    [StringLength(1)]
    public string? ApprOnFileInd { get; set; }

    [Column("order_typ")]
    public int? OrderTyp { get; set; }

    [Column("po_time_frame")]
    public int? PoTimeFrame { get; set; }

    [Column("po_time")]
    public int? PoTime { get; set; }

    [Column("inst_po_id")]
    public int? InstPoId { get; set; }

    [Column("cat_typ")]
    public int? CatTyp { get; set; }

    [Column("po_seq_no")]
    public int? PoSeqNo { get; set; }

    [Column("po_desc")]
    [StringLength(255)]
    public string? PoDesc { get; set; }

    [Column("po_cat")]
    [StringLength(40)]
    public string? PoCat { get; set; }

    [Column("po_details")]
    [StringLength(255)]
    public string? PoDetails { get; set; }

    [Column("po_sheet_id")]
    public int? PoSheetId { get; set; }

    [Column("cancel_entry_ind")]
    [StringLength(1)]
    public string? CancelEntryInd { get; set; }

    [Column("recurring_ind")]
    [StringLength(1)]
    public string? RecurringInd { get; set; }

    [Column("vrbl_cmt")]
    [StringLength(255)]
    public string? VrblCmt { get; set; }

    [Column("po_time_frame_date", TypeName = "datetime")]
    public DateTime? PoTimeFrameDate { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("pthwy_order")]
    [StringLength(1)]
    public string? PthwyOrder { get; set; }

    [Column("ext_tp_name")]
    [StringLength(40)]
    public string? ExtTpName { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [InverseProperty("VrblOrder")]
    public virtual ICollection<PtVisit> PtVisit { get; set; } = new List<PtVisit>();

    [InverseProperty("VrblOrder")]
    public virtual ICollection<TherapyItemAdmn> TherapyItemAdmn { get; set; } = new List<TherapyItemAdmn>();

    [InverseProperty("VrblOrder")]
    public virtual ICollection<TxVrtn> TxVrtn { get; set; } = new List<TxVrtn>();

    [InverseProperty("VrblOrder")]
    public virtual ICollection<VrblOrderDetail> VrblOrderDetail { get; set; } = new List<VrblOrderDetail>();
}
