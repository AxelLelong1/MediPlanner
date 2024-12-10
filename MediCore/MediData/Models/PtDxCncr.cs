using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtDxId")]
[Table("pt_dx_cncr")]
public partial class PtDxCncr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_dx_id")]
    public int PtDxId { get; set; }

    [Column("nodes_examined")]
    public int? NodesExamined { get; set; }

    [Column("nodes_pos")]
    public int? NodesPos { get; set; }

    [Column("icdo_site_typ")]
    public int? IcdoSiteTyp { get; set; }

    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string? IcdoSiteCd { get; set; }

    [Column("icdo_site_seq")]
    public int? IcdoSiteSeq { get; set; }

    [Column("morph_cd_typ")]
    public int? MorphCdTyp { get; set; }

    [Column("morph_cd")]
    [StringLength(4)]
    public string? MorphCd { get; set; }

    [Column("morph_cd_seq")]
    public int? MorphCdSeq { get; set; }

    [Column("behavior_cd")]
    [StringLength(1)]
    public string? BehaviorCd { get; set; }

    [Column("hst_grade_typ")]
    public int? HstGradeTyp { get; set; }

    [Column("laterality_typ")]
    public int? LateralityTyp { get; set; }

    [Column("cncr_desc")]
    [StringLength(250)]
    public string? CncrDesc { get; set; }

    [Column("les_order_no")]
    public int? LesOrderNo { get; set; }

    [Column("meas_ind")]
    [StringLength(1)]
    public string? MeasInd { get; set; }

    [Column("meas_dim")]
    public int? MeasDim { get; set; }

    [Column("meas_mask")]
    [StringLength(11)]
    public string? MeasMask { get; set; }

    [Column("prmy_dx_id")]
    public int? PrmyDxId { get; set; }

    [Column("resect_ind")]
    [StringLength(1)]
    public string? ResectInd { get; set; }

    [Column("recur_ind")]
    [StringLength(1)]
    public string? RecurInd { get; set; }

    [Column("invasive_ind")]
    [StringLength(1)]
    public string? InvasiveInd { get; set; }

    [Column("met_ind")]
    [StringLength(1)]
    public string? MetInd { get; set; }

    [Column("prmy_cncr_id")]
    public int? PrmyCncrId { get; set; }

    [Column("er_status")]
    [StringLength(1)]
    public string? ErStatus { get; set; }

    [Column("pr_status")]
    [StringLength(1)]
    public string? PrStatus { get; set; }

    [Column("gleason_prmy")]
    public int? GleasonPrmy { get; set; }

    [Column("gleason_scndy")]
    public int? GleasonScndy { get; set; }

    [Column("gleason_total")]
    public int? GleasonTotal { get; set; }

    [Column("cores_taken")]
    public int? CoresTaken { get; set; }

    [Column("cores_pos")]
    public int? CoresPos { get; set; }

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

    [Column("her2neu_ind")]
    [StringLength(1)]
    public string? Her2neuInd { get; set; }

    [Column("s_phase", TypeName = "decimal(11, 4)")]
    public decimal? SPhase { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("prmy_cncr_site_value_id")]
    public int? PrmyCncrSiteValueId { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("tumor_size", TypeName = "decimal(11, 4)")]
    public decimal? TumorSize { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("dx_cncr_cmt")]
    [StringLength(255)]
    public string? DxCncrCmt { get; set; }

    [Column("les_desc")]
    [StringLength(100)]
    public string? LesDesc { get; set; }

    [Column("les_track_ind")]
    [StringLength(1)]
    public string? LesTrackInd { get; set; }

    [Column("cores_pos_left")]
    public int? CoresPosLeft { get; set; }

    [Column("cores_pos_right")]
    public int? CoresPosRight { get; set; }

    [Column("cores_taken_left")]
    public int? CoresTakenLeft { get; set; }

    [Column("cores_taken_right")]
    public int? CoresTakenRight { get; set; }

    [Column("dcis_status_typ")]
    public int? DcisStatusTyp { get; set; }

    [Column("disease_pct_pos_apex_left", TypeName = "decimal(11, 4)")]
    public decimal? DiseasePctPosApexLeft { get; set; }

    [Column("disease_pct_pos_apex_right", TypeName = "decimal(11, 4)")]
    public decimal? DiseasePctPosApexRight { get; set; }

    [Column("disease_pct_pos_base_left", TypeName = "decimal(11, 4)")]
    public decimal? DiseasePctPosBaseLeft { get; set; }

    [Column("disease_pct_pos_base_right", TypeName = "decimal(11, 4)")]
    public decimal? DiseasePctPosBaseRight { get; set; }

    [Column("disease_pct_pos_mid_left", TypeName = "decimal(11, 4)")]
    public decimal? DiseasePctPosMidLeft { get; set; }

    [Column("disease_pct_pos_mid_right", TypeName = "decimal(11, 4)")]
    public decimal? DiseasePctPosMidRight { get; set; }

    [Column("disease_present_apex_ind")]
    [StringLength(1)]
    public string? DiseasePresentApexInd { get; set; }

    [Column("disease_present_apex_left_ind")]
    [StringLength(1)]
    public string? DiseasePresentApexLeftInd { get; set; }

    [Column("disease_present_apex_right_ind")]
    [StringLength(1)]
    public string? DiseasePresentApexRightInd { get; set; }

    [Column("disease_present_base_ind")]
    [StringLength(1)]
    public string? DiseasePresentBaseInd { get; set; }

    [Column("disease_present_base_left_ind")]
    [StringLength(1)]
    public string? DiseasePresentBaseLeftInd { get; set; }

    [Column("disease_present_base_right_ind")]
    [StringLength(1)]
    public string? DiseasePresentBaseRightInd { get; set; }

    [Column("disease_present_mid_ind")]
    [StringLength(1)]
    public string? DiseasePresentMidInd { get; set; }

    [Column("disease_present_mid_left_ind")]
    [StringLength(1)]
    public string? DiseasePresentMidLeftInd { get; set; }

    [Column("disease_present_mid_right_ind")]
    [StringLength(1)]
    public string? DiseasePresentMidRightInd { get; set; }

    [Column("nodes_examined_left")]
    public int? NodesExaminedLeft { get; set; }

    [Column("nodes_examined_right")]
    public int? NodesExaminedRight { get; set; }

    [Column("nodes_pos_left")]
    public int? NodesPosLeft { get; set; }

    [Column("nodes_pos_right")]
    public int? NodesPosRight { get; set; }

    [Column("ece_status_typ")]
    public int? EceStatusTyp { get; set; }

    [Column("gleason_tertiary_typ")]
    public int? GleasonTertiaryTyp { get; set; }

    [Column("her2neu_method_typ")]
    public int? Her2neuMethodTyp { get; set; }

    [Column("her2neu_status_typ")]
    public int? Her2neuStatusTyp { get; set; }

    [Column("margin_loc")]
    [StringLength(255)]
    public string? MarginLoc { get; set; }

    [Column("margin_status_typ")]
    public int? MarginStatusTyp { get; set; }

    [Column("microcalc_status_typ")]
    public int? MicrocalcStatusTyp { get; set; }

    [Column("multifocal_ind")]
    [StringLength(1)]
    public string? MultifocalInd { get; set; }

    [Column("necrosis_status_typ")]
    public int? NecrosisStatusTyp { get; set; }

    [Column("nodes_assessed_ind")]
    [StringLength(1)]
    public string? NodesAssessedInd { get; set; }

    [Column("nodes_cytokeratin_pos")]
    public int? NodesCytokeratinPos { get; set; }

    [Column("nodes_largest_size", TypeName = "decimal(11, 4)")]
    public decimal? NodesLargestSize { get; set; }

    [Column("oncotypedx_risk_typ")]
    public int? OncotypedxRiskTyp { get; set; }

    [Column("oncotypedx_score")]
    public int? OncotypedxScore { get; set; }

    [Column("pathology_cmt")]
    [StringLength(255)]
    public string? PathologyCmt { get; set; }

    [Column("pin_status_typ")]
    public int? PinStatusTyp { get; set; }

    [Column("tumor_meas_typ")]
    public int? TumorMeasTyp { get; set; }

    [Column("in_situ_cncr_ind")]
    [StringLength(1)]
    public string? InSituCncrInd { get; set; }

    [Column("ki67_status_typ")]
    public int? Ki67StatusTyp { get; set; }

    [Column("ki67_pct", TypeName = "decimal(11, 4)")]
    public decimal? Ki67Pct { get; set; }

    [Column("her2neu_method2_typ")]
    public int? Her2neuMethod2Typ { get; set; }

    [Column("her2neu_status2_typ")]
    public int? Her2neuStatus2Typ { get; set; }

    [Column("kras_status_typ")]
    public int? KrasStatusTyp { get; set; }

    [Column("dx_icd_site_unlocked_ind")]
    [StringLength(1)]
    public string DxIcdSiteUnlockedInd { get; set; } = null!;

    [InverseProperty("PtDxCncr")]
    public virtual ICollection<PtCncrStatus> PtCncrStatus { get; set; } = new List<PtCncrStatus>();

    [InverseProperty("PtDxCncr")]
    public virtual ICollection<PtCncrStatusMh> PtCncrStatusMh { get; set; } = new List<PtCncrStatusMh>();

    [ForeignKey("PtId, PtDxId")]
    [InverseProperty("PtDxCncr")]
    public virtual PtDx PtDx { get; set; } = null!;

    [InverseProperty("PtDxCncr")]
    public virtual ICollection<PtLes> PtLes { get; set; } = new List<PtLes>();

    [InverseProperty("PtDxCncr")]
    public virtual ICollection<PtLesMh> PtLesMh { get; set; } = new List<PtLesMh>();
}
