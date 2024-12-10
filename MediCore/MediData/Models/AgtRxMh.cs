using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "ItemNo", "RevisionNo")]
[Table("agt_rx_mh")]
public partial class AgtRxMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("rx_id")]
    public int RxId { get; set; }

    [Key]
    [Column("item_no")]
    public int ItemNo { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [Column("dose_level")]
    public int? DoseLevel { get; set; }

    [Column("rx_dose", TypeName = "numeric(11, 4)")]
    public decimal? RxDose { get; set; }

    [Column("rx_total", TypeName = "numeric(18, 4)")]
    public decimal? RxTotal { get; set; }

    [Column("admn_dosage_unit")]
    public int AdmnDosageUnit { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("admn_dose_frq_unit")]
    public int? AdmnDoseFrqUnit { get; set; }

    [Column("admn_frq_x")]
    public int? AdmnFrqX { get; set; }

    [Column("admn_frq_unit")]
    public int? AdmnFrqUnit { get; set; }

    [Column("admn_dur")]
    public int? AdmnDur { get; set; }

    [Column("admn_dur_unit")]
    public int? AdmnDurUnit { get; set; }

    [Column("req")]
    [StringLength(1)]
    public string Req { get; set; } = null!;

    [Column("agt_status")]
    [StringLength(1)]
    public string? AgtStatus { get; set; }

    [Column("subs_allowed")]
    [StringLength(1)]
    public string? SubsAllowed { get; set; }

    [Column("discontinue_date", TypeName = "datetime")]
    public DateTime? DiscontinueDate { get; set; }

    [Column("admn_start_date", TypeName = "datetime")]
    public DateTime? AdmnStartDate { get; set; }

    [Column("subs_reason")]
    public string? SubsReason { get; set; }

    [Column("general_orders")]
    public string? GeneralOrders { get; set; }

    [Column("discontinue_reason")]
    public string? DiscontinueReason { get; set; }

    [Column("dc_eff_date", TypeName = "datetime")]
    public DateTime? DcEffDate { get; set; }

    [Column("prn_ind")]
    [StringLength(1)]
    public string? PrnInd { get; set; }

    [Column("prn_repeat_ind")]
    [StringLength(1)]
    public string? PrnRepeatInd { get; set; }

    [Column("rx_dose_range", TypeName = "numeric(11, 4)")]
    public decimal? RxDoseRange { get; set; }

    [Column("strength", TypeName = "numeric(11, 4)")]
    public decimal? Strength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

    [Column("set_intv_id")]
    public int? SetIntvId { get; set; }

    [Column("set_date_tp_init", TypeName = "datetime")]
    public DateTime? SetDateTpInit { get; set; }

    [Column("set_order_id")]
    public int? SetOrderId { get; set; }

    [Column("dispense_qty", TypeName = "numeric(11, 0)")]
    public decimal? DispenseQty { get; set; }

    [Column("course_desc")]
    [StringLength(255)]
    public string? CourseDesc { get; set; }

    [Column("dow_frq_unit")]
    public int? DowFrqUnit { get; set; }

    [Column("week_frq_unit")]
    public int? WeekFrqUnit { get; set; }

    [Column("placer_order_no")]
    [StringLength(15)]
    public string? PlacerOrderNo { get; set; }

    [Column("order_unit")]
    public int? OrderUnit { get; set; }

    [Column("order_dose", TypeName = "numeric(11, 4)")]
    public decimal? OrderDose { get; set; }

    [Column("agt_seq_no")]
    public int? AgtSeqNo { get; set; }

    [Column("infusion_typ")]
    public int? InfusionTyp { get; set; }

    [Column("infusion_duration")]
    public int? InfusionDuration { get; set; }

    [Column("infusion_timescale")]
    public int? InfusionTimescale { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("prn_reason_typ")]
    public int? PrnReasonTyp { get; set; }

    [Column("rx_typ")]
    public int? RxTyp { get; set; }

    [Column("refill_ind")]
    [StringLength(1)]
    public string? RefillInd { get; set; }

    [Column("refill_qty")]
    public int? RefillQty { get; set; }

    [Column("dispensed_ind")]
    [StringLength(1)]
    public string? DispensedInd { get; set; }

    [Column("dose_strength")]
    [StringLength(15)]
    public string? DoseStrength { get; set; }

    [Column("ind")]
    [StringLength(255)]
    public string? Ind { get; set; }

    [Column("agt_vol", TypeName = "numeric(11, 4)")]
    public decimal? AgtVol { get; set; }

    [Column("agt_vol_uom")]
    public int? AgtVolUom { get; set; }

    [Column("rx_hydra_id")]
    public int? RxHydraId { get; set; }

    [Column("disp_dose_level_ind")]
    [StringLength(1)]
    public string? DispDoseLevelInd { get; set; }

    [Column("dose_rec_ind")]
    [StringLength(1)]
    public string? DoseRecInd { get; set; }

    [Column("inactivate_ind")]
    [StringLength(1)]
    public string? InactivateInd { get; set; }

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

    [Column("dose_pct", TypeName = "numeric(11, 4)")]
    public decimal? DosePct { get; set; }

    [Column("order_chg_ind")]
    [StringLength(1)]
    public string? OrderChgInd { get; set; }

    [Column("ad_hoc_active_entry_ind")]
    [StringLength(1)]
    public string? AdHocActiveEntryInd { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("take_as_directed_ind")]
    [StringLength(1)]
    public string? TakeAsDirectedInd { get; set; }

    [Column("dispense_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispenseVol { get; set; }

    [Column("dispense_unit")]
    public int? DispenseUnit { get; set; }

    [Column("admn_frq_upper_x")]
    public int? AdmnFrqUpperX { get; set; }

    [Column("not_dispensed_ind")]
    [StringLength(1)]
    public string? NotDispensedInd { get; set; }

    [Column("disp_loc_id")]
    public int? DispLocId { get; set; }

    [Column("ovride_dose_times_ind")]
    [StringLength(1)]
    public string? OvrideDoseTimesInd { get; set; }

    [Column("sync_dose_times_ind")]
    [StringLength(1)]
    public string? SyncDoseTimesInd { get; set; }

    [Column("review_req_ind")]
    [StringLength(1)]
    public string? ReviewReqInd { get; set; }

    [Column("continue_rx_ind")]
    [StringLength(1)]
    public string? ContinueRxInd { get; set; }

    [Column("admn_dose_change_ind")]
    [StringLength(1)]
    public string? AdmnDoseChangeInd { get; set; }

    [Column("admn_dose_no_rec")]
    public int? AdmnDoseNoRec { get; set; }

    [Column("admn_dose_total")]
    public int? AdmnDoseTotal { get; set; }

    [Column("doses_on_hold")]
    public int? DosesOnHold { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("rsn_typ")]
    public int? RsnTyp { get; set; }

    [Column("rsn_desc")]
    [StringLength(255)]
    public string? RsnDesc { get; set; }

    [Column("hydra_rate_ovride_typ")]
    [StringLength(1)]
    public string? HydraRateOvrideTyp { get; set; }

    [Column("hydra_rate_ovride_rsn_cmt")]
    [StringLength(255)]
    public string? HydraRateOvrideRsnCmt { get; set; }

    [Column("hydra_rate_ovride_userid")]
    [StringLength(255)]
    public string? HydraRateOvrideUserid { get; set; }

    [Column("hydra_rate_ovride_inst_id")]
    [StringLength(30)]
    public string? HydraRateOvrideInstId { get; set; }

    [Column("hydra_rate_ovride_tstamp", TypeName = "datetime")]
    public DateTime? HydraRateOvrideTstamp { get; set; }

    [Column("agt_level_status")]
    [StringLength(1)]
    public string? AgtLevelStatus { get; set; }

    [Column("agt_display_order")]
    public int? AgtDisplayOrder { get; set; }

    [Column("printed_cnt")]
    public int PrintedCnt { get; set; }

    [Column("pharm_instr")]
    public string? PharmInstr { get; set; }

    [Column("disp_qty_string")]
    [StringLength(15)]
    public string? DispQtyString { get; set; }

    [Column("inst_last_dose_chk_pct", TypeName = "numeric(11, 4)")]
    public decimal? InstLastDoseChkPct { get; set; }

    [Column("inst_last_dose_chk_typ")]
    public int? InstLastDoseChkTyp { get; set; }

    [Column("inst_last_dose_chk_uom")]
    [StringLength(1)]
    public string? InstLastDoseChkUom { get; set; }

    [Column("last_dose_status_typ")]
    [StringLength(1)]
    public string? LastDoseStatusTyp { get; set; }

    [Column("last_dose_pt_visit_id")]
    public int? LastDosePtVisitId { get; set; }

    [Column("last_dose_rx_id")]
    public int? LastDoseRxId { get; set; }

    [Column("last_dose_item_no")]
    public int? LastDoseItemNo { get; set; }

    [Column("formulary_checked_ind")]
    [StringLength(1)]
    public string? FormularyCheckedInd { get; set; }

    [Column("drug_lot_no")]
    [StringLength(30)]
    public string? DrugLotNo { get; set; }

    [Column("agt_manufacturer_id")]
    public int? AgtManufacturerId { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("admn_site_id")]
    public int? AdmnSiteId { get; set; }

    [Column("concentration")]
    [StringLength(15)]
    public string? Concentration { get; set; }

    [Column("prepared_ind")]
    [StringLength(1)]
    public string? PreparedInd { get; set; }

    [Column("drug_cls")]
    [StringLength(1)]
    public string? DrugCls { get; set; }
}
