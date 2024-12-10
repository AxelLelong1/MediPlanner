using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientDiagnosisModel
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    public int DiagnosisTableName { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string DiagnosisType { get; set; } = null!;

    [StringLength(250)]
    public string? DiagnosisDescription { get; set; }

    [StringLength(41)]
    public string? DxDate { get; set; }

    public int? DiagnosisStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DiagnosisStatusDate { get; set; }

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

    [Column("ICDOSite")]
    [StringLength(1)]
    [Unicode(false)]
    public string Icdosite { get; set; } = null!;

    [Column("ICDOVersion")]
    public int Icdoversion { get; set; }

    [StringLength(50)]
    public string? Behaviour { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CellType { get; set; } = null!;

    public int CellCategory { get; set; }

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

    [StringLength(1)]
    [Unicode(false)]
    public string HerNeu { get; set; } = null!;

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

    public int IsCancerDx { get; set; }

    [Column("ctrDiagnosisSer")]
    public long? CtrDiagnosisSer { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }
}
