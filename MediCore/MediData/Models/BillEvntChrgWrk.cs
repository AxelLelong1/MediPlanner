using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_evnt_chrg_wrk")]
[Index("BillSysId", "InstId", "PtId", "PtVisitId", "BillEvntId", Name = "nc1_bill_evnt_chrg_wrk")]
public partial class BillEvntChrgWrk
{
    [Column("bill_sys_id")]
    [StringLength(20)]
    public string BillSysId { get; set; } = null!;

    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string BillSysInstId { get; set; } = null!;

    [Key]
    [Column("trans_id")]
    [StringLength(12)]
    public string TransId { get; set; } = null!;

    [Column("batch_setup_id")]
    public int? BatchSetupId { get; set; }

    [Column("batch_group_id")]
    public int? BatchGroupId { get; set; }

    [Column("batch_group_no")]
    public int? BatchGroupNo { get; set; }

    [Column("batch_seq_no")]
    public int? BatchSeqNo { get; set; }

    [Column("batch_no")]
    [StringLength(20)]
    public string? BatchNo { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("bill_evnt_id")]
    public int? BillEvntId { get; set; }

    [Column("trans_typ")]
    [StringLength(8)]
    public string? TransTyp { get; set; }

    [Column("batch_id")]
    [StringLength(12)]
    public string? BatchId { get; set; }

    [Column("bill_event_typ_id")]
    public int? BillEventTypId { get; set; }

    [Column("bill_event_bill_cd")]
    [StringLength(30)]
    public string? BillEventBillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }

    [Column("bill_event_date", TypeName = "datetime")]
    public DateTime? BillEventDate { get; set; }

    [Column("bill_event_desc")]
    [StringLength(200)]
    public string? BillEventDesc { get; set; }

    [Column("bill_event_units")]
    public int? BillEventUnits { get; set; }

    [Column("bill_cd_bill_price", TypeName = "decimal(8, 2)")]
    public decimal? BillCdBillPrice { get; set; }

    [Column("phys_inst_id")]
    [StringLength(30)]
    public string? PhysInstId { get; set; }

    [Column("phys_userid")]
    [StringLength(255)]
    public string? PhysUserid { get; set; }

    [Column("loc_id")]
    public int? LocId { get; set; }

    [Column("external_org_stkh_id")]
    [StringLength(20)]
    public string? ExternalOrgStkhId { get; set; }

    [Column("batch_desc")]
    [StringLength(80)]
    public string? BatchDesc { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string? BillCd { get; set; }

    [Column("bill_event_link_cd")]
    [StringLength(1)]
    public string? BillEventLinkCd { get; set; }

    [Column("prmy_bill_evnt_id")]
    public int? PrmyBillEvntId { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string? IntfAppParmId { get; set; }

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

    [Column("assoc_cnt")]
    public int? AssocCnt { get; set; }

    [Column("bill_sys_bill_cd_typ")]
    [StringLength(10)]
    public string? BillSysBillCdTyp { get; set; }

    [Column("bill_sys_bill_cd")]
    [StringLength(30)]
    public string? BillSysBillCd { get; set; }

    [Column("bill_modifier")]
    [StringLength(20)]
    public string? BillModifier { get; set; }

    [Column("bill_acct_id")]
    public int? BillAcctId { get; set; }

    [Column("filler_ref_no")]
    [StringLength(12)]
    public string? FillerRefNo { get; set; }

    [Column("plcy_typ_id")]
    public int? PlcyTypId { get; set; }

    [Column("plcy_group_typ_id")]
    public int? PlcyGroupTypId { get; set; }

    [Column("bill_cd_inv_id")]
    [StringLength(10)]
    public string? BillCdInvId { get; set; }

    [ForeignKey("BatchSetupId, BatchGroupId")]
    [InverseProperty("BillEvntChrgWrk")]
    public virtual BillSysBatchGroup? BillSysBatchGroup { get; set; }

    [ForeignKey("BillSysInstId, BillSysId")]
    [InverseProperty("BillEvntChrgWrk")]
    public virtual BillSystem BillSystem { get; set; } = null!;
}
