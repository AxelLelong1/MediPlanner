using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AdmnId")]
[Table("therapy_item_admn")]
[Index("ExpectedDateTime", Name = "nc1_therapy_item_admn")]
[Index("PtId", "DoseAppr", "ExpectedDateTime", Name = "nc2_therapy_item_admn")]
[Index("PtId", "AgtName", "DosageForm", Name = "nc3_therapy_item_admn")]
public partial class TherapyItemAdmn
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("admn_id")]
    public int AdmnId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("rx_id")]
    public int RxId { get; set; }

    [Column("item_no")]
    public int ItemNo { get; set; }

    [Column("admn_seq_no")]
    public int AdmnSeqNo { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [Column("dose_level")]
    public int? DoseLevel { get; set; }

    [Column("date_time_admst", TypeName = "datetime")]
    public DateTime? DateTimeAdmst { get; set; }

    [Column("agt_admn_typ")]
    public int? AgtAdmnTyp { get; set; }

    [Column("agt_admn_seq_no")]
    public int? AgtAdmnSeqNo { get; set; }

    [Column("admn_as_advised")]
    [StringLength(1)]
    public string? AdmnAsAdvised { get; set; }

    [Column("admn_dose", TypeName = "decimal(11, 4)")]
    public decimal? AdmnDose { get; set; }

    [Column("dose_appr")]
    [StringLength(1)]
    public string? DoseAppr { get; set; }

    [Column("admn_item_note_txt")]
    public string? AdmnItemNoteTxt { get; set; }

    [Column("admn_item_note_typ")]
    public int? AdmnItemNoteTyp { get; set; }

    [Column("how_recorded")]
    public int? HowRecorded { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("userid_link")]
    [StringLength(255)]
    public string? UseridLink { get; set; }

    [Column("no_doses_taken", TypeName = "decimal(6, 2)")]
    public decimal? NoDosesTaken { get; set; }

    [Column("expected_date_time", TypeName = "datetime")]
    public DateTime? ExpectedDateTime { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("admn_dose_unit")]
    public int? AdmnDoseUnit { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("course_adj_ind")]
    [StringLength(1)]
    public string? CourseAdjInd { get; set; }

    [Column("adjust_vrbl_id")]
    public int? AdjustVrblId { get; set; }

    [Column("admn_stop_tstamp", TypeName = "datetime")]
    public DateTime? AdmnStopTstamp { get; set; }

    [Column("variance_ind")]
    [StringLength(1)]
    public string? VarianceInd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("disp_verified_tstamp", TypeName = "datetime")]
    public DateTime? DispVerifiedTstamp { get; set; }

    [Column("dispensed_ind")]
    [StringLength(1)]
    public string? DispensedInd { get; set; }

    [Column("course_desc")]
    [StringLength(255)]
    public string? CourseDesc { get; set; }

    [Column("corrected_entry_ind")]
    [StringLength(1)]
    public string? CorrectedEntryInd { get; set; }

    [Column("ad_hoc_entry_ind")]
    [StringLength(1)]
    public string? AdHocEntryInd { get; set; }

    [Column("not_dispensed_ind")]
    [StringLength(1)]
    public string? NotDispensedInd { get; set; }

    [Column("disp_loc_id")]
    public int? DispLocId { get; set; }

    [Column("on_hold_ind")]
    [StringLength(1)]
    public string? OnHoldInd { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("dose_wastage_amt", TypeName = "numeric(11, 4)")]
    public decimal? DoseWastageAmt { get; set; }

    [Column("dose_wastage_unit")]
    public int? DoseWastageUnit { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("drug_lot_no")]
    [StringLength(30)]
    public string? DrugLotNo { get; set; }

    [Column("agt_manufacturer_id")]
    public int? AgtManufacturerId { get; set; }

    [Column("disclosed_flag")]
    [StringLength(1)]
    public string DisclosedFlag { get; set; } = null!;

    [Column("admn_site_id")]
    public int? AdmnSiteId { get; set; }

    [Column("refused_ind")]
    [StringLength(1)]
    public string? RefusedInd { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("prepared_ind")]
    [StringLength(1)]
    public string? PreparedInd { get; set; }

    [ForeignKey("DispLocId")]
    [InverseProperty("TherapyItemAdmn")]
    public virtual DispLoc? DispLoc { get; set; }

    [InverseProperty("TherapyItemAdmn")]
    public virtual ICollection<PtTpActionAgt> PtTpActionAgt { get; set; } = new List<PtTpActionAgt>();

    [InverseProperty("TherapyItemAdmn")]
    public virtual ICollection<TherapyItemAdmnDetail> TherapyItemAdmnDetail { get; set; } = new List<TherapyItemAdmnDetail>();

    [ForeignKey("PtId, AdjustVrblId")]
    [InverseProperty("TherapyItemAdmn")]
    public virtual VrblOrder? VrblOrder { get; set; }
}
