using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DxId", "BillEventId")]
[Table("xref_dx_bill_event")]
[Index("PtId", "BillEventId", Name = "nc1_xref_dx_bill_event")]
public partial class XrefDxBillEvent
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("dx_id")]
    public int DxId { get; set; }

    [Key]
    [Column("bill_event_id")]
    public int BillEventId { get; set; }

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

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("dx_seq_no")]
    public int? DxSeqNo { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [ForeignKey("PtId, BillEventId, PtVisitId")]
    [InverseProperty("XrefDxBillEvent")]
    public virtual BillEvent? BillEvent { get; set; }

    [ForeignKey("PtId, DxId")]
    [InverseProperty("XrefDxBillEvent")]
    public virtual PtDx PtDx { get; set; } = null!;
}
