using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "BillAcctId")]
[Table("bill_acct")]
[Index("PtId", "BillAcctValue", Name = "nc1_bill_acct")]
public partial class BillAcct
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("bill_acct_id")]
    public int BillAcctId { get; set; }

    [Column("bill_inst_id")]
    [StringLength(30)]
    public string BillInstId { get; set; } = null!;

    [Column("bill_acct_label")]
    [StringLength(255)]
    public string BillAcctLabel { get; set; } = null!;

    [Column("bill_acct_value")]
    [StringLength(20)]
    public string BillAcctValue { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("intf_external_field_1")]
    [StringLength(50)]
    public string? IntfExternalField1 { get; set; }

    [Column("intf_external_field_2")]
    [StringLength(50)]
    public string? IntfExternalField2 { get; set; }

    [Column("intf_external_field_3")]
    [StringLength(50)]
    public string? IntfExternalField3 { get; set; }

    [Column("intf_external_field_4")]
    [StringLength(50)]
    public string? IntfExternalField4 { get; set; }

    [Column("intf_external_field_5")]
    [StringLength(50)]
    public string? IntfExternalField5 { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("ext_ref_stkh_id")]
    [StringLength(20)]
    public string? ExtRefStkhId { get; set; }

    [Column("hl7_pt_cls_typ_inst_id")]
    [StringLength(30)]
    public string? Hl7PtClsTypInstId { get; set; }

    [Column("hl7_pt_cls_typ")]
    public int? Hl7PtClsTyp { get; set; }

    [Column("hl7_fin_cls_typ_inst_id")]
    [StringLength(30)]
    public string? Hl7FinClsTypInstId { get; set; }

    [Column("hl7_fin_cls_typ")]
    public int? Hl7FinClsTyp { get; set; }

    [Column("hl7_pt_status_typ_inst_id")]
    [StringLength(30)]
    public string? Hl7PtStatusTypInstId { get; set; }

    [Column("hl7_pt_status_typ")]
    public int? Hl7PtStatusTyp { get; set; }

    [Column("hl7_pt_typ_inst_id")]
    [StringLength(30)]
    public string? Hl7PtTypInstId { get; set; }

    [Column("hl7_pt_typ")]
    public int? Hl7PtTyp { get; set; }

    [Column("hl7_hosp_service_typ_inst_id")]
    [StringLength(30)]
    public string? Hl7HospServiceTypInstId { get; set; }

    [Column("hl7_hosp_service_typ")]
    public int? Hl7HospServiceTyp { get; set; }

    [Column("radonc_typ")]
    [StringLength(1)]
    public string? RadoncTyp { get; set; }

    [InverseProperty("BillAcct")]
    public virtual ICollection<BillAcctPtVisit> BillAcctPtVisit { get; set; } = new List<BillAcctPtVisit>();

    [ForeignKey("Hl7FinClsTypInstId, Hl7FinClsTyp")]
    [InverseProperty("BillAcct")]
    public virtual Hl7FinClsTyp? Hl7FinClsTypNavigation { get; set; }

    [ForeignKey("Hl7HospServiceTypInstId, Hl7HospServiceTyp")]
    [InverseProperty("BillAcct")]
    public virtual Hl7HospServiceTyp? Hl7HospServiceTypNavigation { get; set; }

    [ForeignKey("Hl7PtClsTypInstId, Hl7PtClsTyp")]
    [InverseProperty("BillAcct")]
    public virtual Hl7PtClsTyp? Hl7PtClsTypNavigation { get; set; }

    [ForeignKey("Hl7PtStatusTypInstId, Hl7PtStatusTyp")]
    [InverseProperty("BillAcct")]
    public virtual Hl7PtStatusTyp? Hl7PtStatusTypNavigation { get; set; }

    [ForeignKey("Hl7PtTypInstId, Hl7PtTyp")]
    [InverseProperty("BillAcct")]
    public virtual Hl7PtTyp? Hl7PtTypNavigation { get; set; }

    [ForeignKey("StkhId")]
    [InverseProperty("BillAcct")]
    public virtual Stkh? Stkh { get; set; }

    [InverseProperty("BillAcct")]
    public virtual ICollection<Test> Test { get; set; } = new List<Test>();

    [InverseProperty("BillAcct")]
    public virtual ICollection<VisitNote> VisitNote { get; set; } = new List<VisitNote>();
}
