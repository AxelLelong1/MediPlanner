using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("xref_agt_pt_external")]
[Index("PtId", Name = "nc1_xref_agt_pt_external")]
public partial class XrefAgtPtExternal
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("xref_agt_pt_external_id")]
    public int XrefAgtPtExternalId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int DosageForm { get; set; }

    [Column("xref_agt_pt_ext_recon_ind")]
    [StringLength(1)]
    public string XrefAgtPtExtReconInd { get; set; } = null!;

    [Column("xref_agt_pt_ext_added_ind")]
    [StringLength(1)]
    public string? XrefAgtPtExtAddedInd { get; set; }

    [Column("dose_level")]
    public int? DoseLevel { get; set; }

    [Column("date_started", TypeName = "datetime")]
    public DateTime? DateStarted { get; set; }

    [Column("cum_dose_to_date", TypeName = "numeric(18, 4)")]
    public decimal? CumDoseToDate { get; set; }

    [Column("date_ended", TypeName = "datetime")]
    public DateTime? DateEnded { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("ind")]
    public string? Ind { get; set; }

    [Column("cum_uom")]
    public int? CumUom { get; set; }

    [Column("dose_amount", TypeName = "numeric(11, 4)")]
    public decimal? DoseAmount { get; set; }

    [Column("date_of_last_dose", TypeName = "datetime")]
    public DateTime? DateOfLastDose { get; set; }

    [Column("admn_dose_frq_unit")]
    public int? AdmnDoseFrqUnit { get; set; }

    [Column("admn_frq_x")]
    public int? AdmnFrqX { get; set; }

    [Column("admn_frq_unit")]
    public int? AdmnFrqUnit { get; set; }

    [Column("admn_dur")]
    public int? AdmnDur { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("admn_dur_unit")]
    public int? AdmnDurUnit { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }

    [Column("external_agt_flag")]
    [StringLength(1)]
    public string? ExternalAgtFlag { get; set; }

    [Column("mthd_of_admn")]
    [StringLength(255)]
    public string? MthdOfAdmn { get; set; }

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string? DrugDescId { get; set; }

    [Column("date_approx_ind")]
    [StringLength(1)]
    public string? DateApproxInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("prn_ind")]
    [StringLength(1)]
    public string? PrnInd { get; set; }

    [Column("general_orders")]
    public string? GeneralOrders { get; set; }

    [Column("dose_amount_range", TypeName = "numeric(11, 4)")]
    public decimal? DoseAmountRange { get; set; }

    [Column("medi_active_ind")]
    [StringLength(1)]
    public string? MediActiveInd { get; set; }

    [Column("active_chg_date", TypeName = "datetime")]
    public DateTime? ActiveChgDate { get; set; }

    [Column("course_desc")]
    [StringLength(255)]
    public string? CourseDesc { get; set; }

    [Column("dow_frq_unit")]
    public int? DowFrqUnit { get; set; }

    [Column("week_frq_unit")]
    public int? WeekFrqUnit { get; set; }

    [Column("date_started_cd")]
    public int? DateStartedCd { get; set; }

    [Column("last_disp_date", TypeName = "datetime")]
    public DateTime? LastDispDate { get; set; }

    [Column("agt_cls")]
    [StringLength(10)]
    public string? AgtCls { get; set; }

    [Column("prn_reason_typ")]
    public int? PrnReasonTyp { get; set; }

    [Column("dose_strength")]
    [StringLength(15)]
    public string? DoseStrength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

    [Column("prior_cum_dose", TypeName = "numeric(18, 4)")]
    public decimal? PriorCumDose { get; set; }

    [Column("cum_dose_cmt")]
    public string? CumDoseCmt { get; set; }

    [Column("prior_cum_uom")]
    public int? PriorCumUom { get; set; }

    [Column("take_as_directed_ind")]
    [StringLength(1)]
    public string? TakeAsDirectedInd { get; set; }

    [Column("admn_frq_upper_x")]
    public int? AdmnFrqUpperX { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("date_ended_cd")]
    public int? DateEndedCd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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

    [Column("Rxnorm_id")]
    [StringLength(30)]
    public string? RxnormId { get; set; }

    [Column("recon_source_typ")]
    public int ReconSourceTyp { get; set; }

    [Column("med_parsing_status")]
    [StringLength(1)]
    public string? MedParsingStatus { get; set; }

    [Column("transition_of_care_inbound_id")]
    public int? TransitionOfCareInboundId { get; set; }

    [Column("drug_lot_no")]
    [StringLength(30)]
    public string? DrugLotNo { get; set; }

    [Column("agt_manufacturer_id")]
    public int? AgtManufacturerId { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("admn_site_id")]
    public int? AdmnSiteId { get; set; }

    [Column("unique_ccda_id")]
    [StringLength(75)]
    public string? UniqueCcdaId { get; set; }

    [ForeignKey("PtId, TransitionOfCareInboundId")]
    [InverseProperty("XrefAgtPtExternal")]
    public virtual TransitionOfCareInbound? TransitionOfCareInbound { get; set; }
}
