using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_evnt_charge")]
[Index("BatchId", Name = "nc1_bill_evnt_charge")]
[Index("PtId", "PtVisitId", "BillEvntId", Name = "nc2_bill_evnt_charge")]
[Index("Hl7MsgCntlId", Name = "nc3_bill_evnt_charge")]
public partial class BillEvntCharge
{
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("bill_evnt_id")]
    public int BillEvntId { get; set; }

    [Key]
    [Column("trans_id")]
    [StringLength(12)]
    public string TransId { get; set; } = null!;

    [Column("trans_type")]
    [StringLength(8)]
    public string? TransType { get; set; }

    [Column("batch_id")]
    [StringLength(12)]
    public string? BatchId { get; set; }

    [Column("void_ind")]
    [StringLength(1)]
    public string? VoidInd { get; set; }

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

    [Column("hl7_msg_cntl_id")]
    [StringLength(30)]
    public string? Hl7MsgCntlId { get; set; }

    [Column("hl7_set_id")]
    public int? Hl7SetId { get; set; }

    [Column("filler_ref_no")]
    [StringLength(12)]
    public string? FillerRefNo { get; set; }

    [Column("plcy_typ_id")]
    public int? PlcyTypId { get; set; }

    [Column("plcy_group_typ_id")]
    public int? PlcyGroupTypId { get; set; }

    [Column("bill_event_units")]
    public int? BillEventUnits { get; set; }

    [Column("bill_cd_bill_price", TypeName = "numeric(8, 2)")]
    public decimal? BillCdBillPrice { get; set; }

    [Column("bill_cd_inv_id")]
    [StringLength(10)]
    public string? BillCdInvId { get; set; }

    [Column("bill_charge_status")]
    [StringLength(1)]
    public string? BillChargeStatus { get; set; }

    [Column("bill_charge_status_txt")]
    [StringLength(255)]
    public string? BillChargeStatusTxt { get; set; }
}
