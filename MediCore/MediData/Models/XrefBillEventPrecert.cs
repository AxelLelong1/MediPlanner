using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "BillEventId", "PtVisitId")]
[Table("xref_bill_event_precert")]
public partial class XrefBillEventPrecert
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("bill_event_id")]
    public int BillEventId { get; set; }

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("trans_cd")]
    [StringLength(1)]
    public string? TransCd { get; set; }

    [Column("reason_cd")]
    [StringLength(1)]
    public string? ReasonCd { get; set; }

    [Column("visit_date", TypeName = "datetime")]
    public DateTime? VisitDate { get; set; }

    [Column("financial_ins_id")]
    public int? FinancialInsId { get; set; }

    [Column("ins_precert_id")]
    public int? InsPrecertId { get; set; }

    [Column("ins_precert_det_id")]
    public int? InsPrecertDetId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId, BillEventId, PtVisitId")]
    [InverseProperty("XrefBillEventPrecert")]
    public virtual BillEvent BillEvent { get; set; } = null!;

    [ForeignKey("PtId, FinancialInsId, InsPrecertId, InsPrecertDetId")]
    [InverseProperty("XrefBillEventPrecert")]
    public virtual PtInsPrecertDet? PtInsPrecertDet { get; set; }
}
