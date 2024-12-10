using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientDiagnosisEnmModel
{
    [Column("icd_cd")]
    [StringLength(16)]
    public string? IcdCd { get; set; }

    public int DiagnosisTableName { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string DiagnosisType { get; set; } = null!;

    [StringLength(41)]
    public string? DxDate { get; set; }

    public int? DiagnosisStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DiagnosisStatusDate { get; set; }

    [StringLength(250)]
    public string? DiagnosisDescription { get; set; }

    [StringLength(1)]
    public string Ranking { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? Source { get; set; }

    [StringLength(512)]
    public string? ClinicalDescription { get; set; }

    [StringLength(254)]
    public string? HistoricDetails { get; set; }

    [StringLength(254)]
    public string? Comments { get; set; }

    [StringLength(255)]
    public string? PathologyComments { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? HistoricDxFlag { get; set; }

    public int BodySystem { get; set; }

    public int DxSite { get; set; }

    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string? IcdoSiteCd { get; set; }

    [Column("icdo_site_seq")]
    public int IcdoSiteSeq { get; set; }

    [Column("ICDOVersion")]
    public int Icdoversion { get; set; }

    [StringLength(50)]
    public string? Behaviour { get; set; }

    public int CellCategory { get; set; }

    public int CellTypeClsSchemeId { get; set; }

    [Column("morph_cd")]
    [StringLength(4)]
    public string? MorphCd { get; set; }

    [Column("morph_cd_seq")]
    public int MorphCdSeq { get; set; }

    [Column("behavior_cd")]
    [StringLength(1)]
    public string BehaviorCd { get; set; } = null!;

    public int? CellGrade { get; set; }

    public int? Laterality { get; set; }

    [StringLength(30)]
    public string? DistantMets { get; set; }

    public int? Nodes { get; set; }

    public int? NodesPositive { get; set; }

    [Column(TypeName = "decimal(11, 4)")]
    public decimal? Size { get; set; }

    [StringLength(50)]
    public string? Stage { get; set; }

    [StringLength(40)]
    public string? StageCriteria { get; set; }

    [StringLength(40)]
    public string? Stagebasis { get; set; }

    [StringLength(64)]
    public string? StageScheme { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? StageStatus { get; set; }

    [Column("ERStatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Erstatus { get; set; }

    [Column("PRStatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Prstatus { get; set; }

    [Column("her2neu_method_typ")]
    public int? Her2neuMethodTyp { get; set; }

    [Column("her2neu_status_typ")]
    public int? Her2neuStatusTyp { get; set; }

    [Column("her2neu_method2_typ")]
    public int? Her2neuMethod2Typ { get; set; }

    [Column("her2neu_status2_typ")]
    public int? Her2neuStatus2Typ { get; set; }

    [Column("SPhase", TypeName = "decimal(11, 4)")]
    public decimal? Sphase { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? Recurrence { get; set; }

    [StringLength(1)]
    public string? Invasive { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? ConfirmedDx { get; set; }

    public int? DxMethodType { get; set; }

    [StringLength(254)]
    public string? MethodDescription { get; set; }

    public int? CoresTaken { get; set; }

    public int? CoresPositive { get; set; }

    public int? GleasonPrimary { get; set; }

    public int? GleasonSecondary { get; set; }

    public int? GleasonTotal { get; set; }

    public int? GleasonScore { get; set; }

    [StringLength(16)]
    public string? ObjectStatus { get; set; }

    [StringLength(16)]
    public string? HistologyCode { get; set; }

    [StringLength(64)]
    public string? HistologyTableName { get; set; }

    [Column("TStage")]
    [StringLength(32)]
    public string? Tstage { get; set; }

    [Column("NStage")]
    [StringLength(32)]
    public string? Nstage { get; set; }

    [Column("MStage")]
    [StringLength(32)]
    public string? Mstage { get; set; }

    [StringLength(32)]
    public string? SummaryStage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateStamp { get; set; }

    [Column("GValue")]
    [StringLength(10)]
    public string? Gvalue { get; set; }

    [StringLength(1)]
    public string? IsMeasurable { get; set; }

    [Column("RValue")]
    [StringLength(10)]
    public string? Rvalue { get; set; }

    [StringLength(1)]
    public string? IsResectable { get; set; }

    [Column("SValue")]
    [StringLength(10)]
    public string? Svalue { get; set; }

    [StringLength(1)]
    public string? StageBasisCode { get; set; }

    [StringLength(1)]
    public string IsTargetLesion { get; set; } = null!;

    [Column("ctrDiagnosisID")]
    public int CtrDiagnosisId { get; set; }

    [Column("ctrDiagnosisSer")]
    public long? CtrDiagnosisSer { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CurrentEntry { get; set; }

    [StringLength(250)]
    public string? CancerDescription { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? CancerStatus { get; set; }

    [StringLength(100)]
    public string? LesionDescription { get; set; }

    public int? LesionOrder { get; set; }

    public int? LesionDimention { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? LesionMeasurable { get; set; }

    [Column("PrimaryCancerID")]
    public int? PrimaryCancerId { get; set; }

    public int? PrimaryCancerSiteId { get; set; }

    public int? PrimaryDiagnosisId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StagedDate { get; set; }

    [Column("ctrpt_stage_id")]
    public int? CtrptStageId { get; set; }

    [Column("cncr_stage")]
    [StringLength(20)]
    public string? CncrStage { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PtDxOnSetDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PtDxLastModifiedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PtDxCncrLastModifiedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DxSiteDateTime { get; set; }

    public int IsCancerDx { get; set; }
}
