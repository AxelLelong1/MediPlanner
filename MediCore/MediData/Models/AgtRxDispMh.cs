using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "ItemNo", "DispId", "RevisionNo")]
[Table("agt_rx_disp_mh")]
public partial class AgtRxDispMh
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
    [Column("disp_id")]
    public int DispId { get; set; }

    [Column("disp_tstamp", TypeName = "datetime")]
    public DateTime? DispTstamp { get; set; }

    [Column("disp_by_userid")]
    [StringLength(255)]
    public string? DispByUserid { get; set; }

    [Column("disp_by_inst_id")]
    [StringLength(30)]
    public string? DispByInstId { get; set; }

    [Column("disp_cmt")]
    [StringLength(255)]
    public string? DispCmt { get; set; }

    [Column("disp_appr_ind")]
    [StringLength(1)]
    public string? DispApprInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("admn_id")]
    public int? AdmnId { get; set; }

    [Column("disp_agt_name")]
    [StringLength(50)]
    public string? DispAgtName { get; set; }

    [Column("disp_dosage_form")]
    public int? DispDosageForm { get; set; }

    [Column("disp_dose", TypeName = "numeric(11, 4)")]
    public decimal? DispDose { get; set; }

    [Column("disp_dose_range", TypeName = "numeric(11, 4)")]
    public decimal? DispDoseRange { get; set; }

    [Column("disp_dose_unit")]
    public int? DispDoseUnit { get; set; }

    [Column("disp_admn_route")]
    public int? DispAdmnRoute { get; set; }

    [Column("disp_order_dose", TypeName = "numeric(11, 4)")]
    public decimal? DispOrderDose { get; set; }

    [Column("disp_order_unit")]
    public int? DispOrderUnit { get; set; }

    [Column("disp_dose_strength")]
    [StringLength(15)]
    public string? DispDoseStrength { get; set; }

    [Column("disp_dose_strength_unit")]
    public int? DispDoseStrengthUnit { get; set; }

    [Column("disp_infusion_typ")]
    public int? DispInfusionTyp { get; set; }

    [Column("disp_infusion_duration")]
    public int? DispInfusionDuration { get; set; }

    [Column("disp_infusion_timescale")]
    public int? DispInfusionTimescale { get; set; }

    [Column("disp_indication")]
    [StringLength(255)]
    public string? DispIndication { get; set; }

    [Column("disp_general_orders")]
    public string? DispGeneralOrders { get; set; }

    [Column("syringe_qty")]
    public int? SyringeQty { get; set; }

    [Column("syringe_vol", TypeName = "numeric(11, 4)")]
    public decimal? SyringeVol { get; set; }

    [Column("syringe_vol_uom")]
    public int? SyringeVolUom { get; set; }

    [Column("disp_chg_ind")]
    [StringLength(1)]
    public string? DispChgInd { get; set; }

    [Column("disp_agt_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispAgtVol { get; set; }

    [Column("disp_agt_vol_uom")]
    public int? DispAgtVolUom { get; set; }

    [Column("rx_hydra_disp_id")]
    public int? RxHydraDispId { get; set; }

    [Column("disp_course_desc")]
    [StringLength(255)]
    public string? DispCourseDesc { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("not_dispensed_ind")]
    [StringLength(1)]
    public string? NotDispensedInd { get; set; }

    [Column("dispense_qty", TypeName = "numeric(11, 0)")]
    public decimal? DispenseQty { get; set; }

    [Column("dispense_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispenseVol { get; set; }

    [Column("dispense_unit")]
    public int? DispenseUnit { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("expiry_date_cd")]
    public int? ExpiryDateCd { get; set; }

    [Column("placer_order_no")]
    [StringLength(10)]
    public string? PlacerOrderNo { get; set; }

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

    [Column("custom_syringe_ind")]
    [StringLength(1)]
    public string? CustomSyringeInd { get; set; }

    [Column("syringe_id")]
    public int? SyringeId { get; set; }

    [Column("review_ind")]
    [StringLength(1)]
    public string? ReviewInd { get; set; }

    [Column("concentration")]
    [StringLength(15)]
    public string? Concentration { get; set; }

    [Column("formulary_checked_ind")]
    [StringLength(1)]
    public string? FormularyCheckedInd { get; set; }

    [Column("prep_dt", TypeName = "datetime")]
    public DateTime? PrepDt { get; set; }

    [Column("prep_by_userid")]
    [StringLength(255)]
    public string? PrepByUserid { get; set; }

    [Column("prep_by_inst_id")]
    [StringLength(30)]
    public string? PrepByInstId { get; set; }

    [Column("expiry_date_calc_ind")]
    [StringLength(1)]
    public string? ExpiryDateCalcInd { get; set; }

    [Column("prepared_ind")]
    [StringLength(1)]
    public string? PreparedInd { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("prep_method_txt")]
    public string? PrepMethodTxt { get; set; }

    [Column("pn_template_id")]
    public int? PnTemplateId { get; set; }

    [Column("pn_inst_id")]
    [StringLength(30)]
    public string? PnInstId { get; set; }
}
