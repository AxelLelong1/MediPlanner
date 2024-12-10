using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt")]
[Index("UpperLastName", Name = "nc1_pt")]
[Index("FirstRemTstamp", Name = "nc2_pt")]
[Index("PtTpAmend", Name = "nc3_pt")]
[Index("PtLastNameSdx", Name = "nc4_pt")]
[Index("PatientSer", Name = "nc5_pt")]
[Index("LastRemTstamp", Name = "nc6_pt")]
public partial class Pt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_last_name")]
    [StringLength(30)]
    public string PtLastName { get; set; } = null!;

    [Column("pt_dob", TypeName = "datetime")]
    public DateTime PtDob { get; set; }

    [Column("cur_last_name")]
    [StringLength(30)]
    public string? CurLastName { get; set; }

    [Column("pt_first_name")]
    [StringLength(30)]
    public string PtFirstName { get; set; } = null!;

    [Column("pt_initial")]
    [StringLength(2)]
    public string PtInitial { get; set; } = null!;

    [Column("sin_ssn")]
    [StringLength(20)]
    public string? SinSsn { get; set; }

    [Column("sex_cd")]
    [StringLength(1)]
    public string SexCd { get; set; } = null!;

    [Column("pt_title")]
    public int? PtTitle { get; set; }

    [Column("title_typ")]
    public int? TitleTyp { get; set; }

    [Column("pt_tp_amend")]
    [StringLength(1)]
    public string? PtTpAmend { get; set; }

    [Column("pt_tp_active_ind")]
    [StringLength(1)]
    public string? PtTpActiveInd { get; set; }

    [Column("inpt_ind")]
    [StringLength(1)]
    public string? InptInd { get; set; }

    [Column("pt_alive_ind")]
    [StringLength(1)]
    public string? PtAliveInd { get; set; }

    [Column("new_order_ind")]
    [StringLength(1)]
    public string? NewOrderInd { get; set; }

    [Column("pt_dod", TypeName = "datetime")]
    public DateTime? PtDod { get; set; }

    [Column("cs_of_dth_typ_id")]
    public int? CsOfDthTypId { get; set; }

    [Column("citizenship_id")]
    public int? CitizenshipId { get; set; }

    [Column("test_pt_ind")]
    [StringLength(1)]
    public string? TestPtInd { get; set; }

    [Column("maiden_name")]
    [StringLength(30)]
    public string? MaidenName { get; set; }

    [Column("pt_dob_cd")]
    public int? PtDobCd { get; set; }

    [Column("pt_dod_cd")]
    public int? PtDodCd { get; set; }

    [Column("upper_last_name")]
    [StringLength(30)]
    public string? UpperLastName { get; set; }

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

    [Column("last_pln_chg_date", TypeName = "datetime")]
    public DateTime? LastPlnChgDate { get; set; }

    [Column("pt_last_name_sdx")]
    [StringLength(6)]
    public string? PtLastNameSdx { get; set; }

    [Column("pt_first_name_sdx")]
    [StringLength(6)]
    public string? PtFirstNameSdx { get; set; }

    [Column("pt_middle_name")]
    [StringLength(30)]
    public string? PtMiddleName { get; set; }

    [Column("new_rem_ind")]
    [StringLength(1)]
    public string? NewRemInd { get; set; }

    [Column("first_rem_tstamp", TypeName = "datetime")]
    public DateTime? FirstRemTstamp { get; set; }

    [Column("last_rem_tstamp", TypeName = "datetime")]
    public DateTime? LastRemTstamp { get; set; }

    [Column("clin_trial_ind")]
    [StringLength(1)]
    public string? ClinTrialInd { get; set; }

    [Column("trans_trf_inst_id")]
    [StringLength(30)]
    public string? TransTrfInstId { get; set; }

    [Column("pt_age")]
    public int? PtAge { get; set; }

    [Column("pt_age_cat")]
    [StringLength(15)]
    public string? PtAgeCat { get; set; }

    [Column("allergy_ind")]
    [StringLength(1)]
    public string? AllergyInd { get; set; }

    [Column("directives_ind")]
    [StringLength(1)]
    public string? DirectivesInd { get; set; }

    [Column("infection_ind")]
    [StringLength(1)]
    public string? InfectionInd { get; set; }

    [Column("pt_inpatient_ind")]
    [StringLength(1)]
    public string? PtInpatientInd { get; set; }

    [Column("pt_alert_ind")]
    [StringLength(1)]
    public string? PtAlertInd { get; set; }

    [Column("track_ae_ind")]
    [StringLength(1)]
    public string? TrackAeInd { get; set; }

    [Column("primary_pt_key_value")]
    [StringLength(20)]
    public string? PrimaryPtKeyValue { get; set; }

    [Column("nka_ind")]
    [StringLength(1)]
    public string? NkaInd { get; set; }

    [Column("ext_agt_ind")]
    [StringLength(1)]
    public string? ExtAgtInd { get; set; }

    [Column("patient_ser")]
    public long? PatientSer { get; set; }

    [Column("pt_password")]
    [StringLength(255)]
    public string? PtPassword { get; set; }

    [Column("pt_portal_reg_ind")]
    [StringLength(1)]
    public string? PtPortalRegInd { get; set; }

    [Column("name_suffix")]
    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [ForeignKey("CitizenshipId")]
    [InverseProperty("Pt")]
    public virtual Country? Citizenship { get; set; }

    [ForeignKey("CsOfDthTypId")]
    [InverseProperty("Pt")]
    public virtual CsOfDthTyp? CsOfDthTyp { get; set; }

    [InverseProperty("Pt")]
    public virtual Financial? Financial { get; set; }

    [InverseProperty("Pt")]
    public virtual ICollection<OncoPtFsDet> OncoPtFsDet { get; set; } = new List<OncoPtFsDet>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtAgendaHdr> PtAgendaHdr { get; set; } = new List<PtAgendaHdr>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtAllergy> PtAllergy { get; set; } = new List<PtAllergy>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtAllergyExternal> PtAllergyExternal { get; set; } = new List<PtAllergyExternal>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtAllergyRespExternal> PtAllergyRespExternal { get; set; } = new List<PtAllergyRespExternal>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtClinicalNotificationCriteria> PtClinicalNotificationCriteria { get; set; } = new List<PtClinicalNotificationCriteria>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtCmt> PtCmt { get; set; } = new List<PtCmt>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtCommLog> PtCommLog { get; set; } = new List<PtCommLog>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtConsent> PtConsent { get; set; } = new List<PtConsent>();

    [InverseProperty("Pt")]
    public virtual PtDemgrAudit? PtDemgrAudit { get; set; }

    [ForeignKey("PtDobCd")]
    [InverseProperty("PtPtDobCdNavigation")]
    public virtual DateCd? PtDobCdNavigation { get; set; }

    [ForeignKey("PtDodCd")]
    [InverseProperty("PtPtDodCdNavigation")]
    public virtual DateCd? PtDodCdNavigation { get; set; }

    [InverseProperty("Pt")]
    public virtual ICollection<PtDoseData> PtDoseData { get; set; } = new List<PtDoseData>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtDx> PtDx { get; set; } = new List<PtDx>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtDxExternal> PtDxExternal { get; set; } = new List<PtDxExternal>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtGuar> PtGuar { get; set; } = new List<PtGuar>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtHxResp> PtHxResp { get; set; } = new List<PtHxResp>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtInfoRequest> PtInfoRequest { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtMuScore> PtMuScore { get; set; } = new List<PtMuScore>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtPrefer> PtPrefer { get; set; } = new List<PtPrefer>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtProfExternal> PtProfExternal { get; set; } = new List<PtProfExternal>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtProvider> PtProvider { get; set; } = new List<PtProvider>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtProviderMu> PtProviderMu { get; set; } = new List<PtProviderMu>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtQm> PtQm { get; set; } = new List<PtQm>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtQmDetail> PtQmDetail { get; set; } = new List<PtQmDetail>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtQmEventCode> PtQmEventCode { get; set; } = new List<PtQmEventCode>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtReconciliationHx> PtReconciliationHx { get; set; } = new List<PtReconciliationHx>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtStatusIcon> PtStatusIcon { get; set; } = new List<PtStatusIcon>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtTp> PtTp { get; set; } = new List<PtTp>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtTpIntvCat> PtTpIntvCat { get; set; } = new List<PtTpIntvCat>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtTumClsValues> PtTumClsValues { get; set; } = new List<PtTumClsValues>();

    [InverseProperty("Pt")]
    public virtual ICollection<PtVisit> PtVisit { get; set; } = new List<PtVisit>();

    [ForeignKey("SexCd")]
    [InverseProperty("Pt")]
    public virtual SexCd SexCdNavigation { get; set; } = null!;

    [ForeignKey("TitleTyp")]
    [InverseProperty("Pt")]
    public virtual TitleTyp? TitleTypNavigation { get; set; }

    [InverseProperty("Pt")]
    public virtual ICollection<XrefAgtPt> XrefAgtPt { get; set; } = new List<XrefAgtPt>();
}
