using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FinancialInsId", "InsPrecertId", "InsPrecertDetId")]
[Table("pt_ins_precert_det")]
public partial class PtInsPrecertDet
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("financial_ins_id")]
    public int FinancialInsId { get; set; }

    [Key]
    [Column("ins_precert_id")]
    public int InsPrecertId { get; set; }

    [Key]
    [Column("ins_precert_det_id")]
    public int InsPrecertDetId { get; set; }

    [Column("ins_precert_typ")]
    public int InsPrecertTyp { get; set; }

    [Column("precert_req_ind")]
    [StringLength(1)]
    public string PrecertReqInd { get; set; } = null!;

    [Column("precert_rcv_ind")]
    [StringLength(1)]
    public string PrecertRcvInd { get; set; } = null!;

    [Column("covered_amt")]
    public int? CoveredAmt { get; set; }

    [Column("precert_det_cmt")]
    public string? PrecertDetCmt { get; set; }

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

    [Column("remn_amt")]
    public int? RemnAmt { get; set; }

    [Column("used_amt")]
    public int? UsedAmt { get; set; }

    [Column("auto_adjust_ind")]
    [StringLength(1)]
    public string? AutoAdjustInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [ForeignKey("InsPrecertTyp")]
    [InverseProperty("PtInsPrecertDet")]
    public virtual InsPrecertTyp InsPrecertTypNavigation { get; set; } = null!;

    [ForeignKey("PtId, FinancialInsId, InsPrecertId")]
    [InverseProperty("PtInsPrecertDet")]
    public virtual PtInsPrecert PtInsPrecert { get; set; } = null!;

    [InverseProperty("PtInsPrecertDet")]
    public virtual ICollection<XrefBillEventPrecert> XrefBillEventPrecert { get; set; } = new List<XrefBillEventPrecert>();
}
