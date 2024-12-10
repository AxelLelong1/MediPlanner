using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class PtNonCncrDiagnosis
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("patient_ser")]
    public long? PatientSer { get; set; }

    [Column("icd_cd")]
    [StringLength(16)]
    public string? IcdCd { get; set; }

    [Column("onset_date", TypeName = "datetime")]
    public DateTime? OnsetDate { get; set; }

    [Column("icdo_site_cd")]
    public int? IcdoSiteCd { get; set; }

    [Column("morph_cd")]
    public int? MorphCd { get; set; }

    [Column("behavior_cd")]
    [StringLength(2)]
    public string? BehaviorCd { get; set; }

    [Column("laterality_typ")]
    public int? LateralityTyp { get; set; }

    [Column("hst_grade_typ")]
    public int? HstGradeTyp { get; set; }

    [Column("nodes_examined")]
    public int? NodesExamined { get; set; }

    [Column("nodes_pos")]
    public int? NodesPos { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("cncr_stage_1")]
    [StringLength(40)]
    public string? CncrStage1 { get; set; }

    [Column("crit_desc_1")]
    [StringLength(80)]
    public string? CritDesc1 { get; set; }

    [Column("stage_basis_1")]
    [StringLength(2)]
    public string? StageBasis1 { get; set; }

    [Column("scheme_name_1")]
    [StringLength(128)]
    public string? SchemeName1 { get; set; }

    [Column("cncr_stage_2")]
    [StringLength(40)]
    public string? CncrStage2 { get; set; }

    [Column("crit_desc_2")]
    [StringLength(80)]
    public string? CritDesc2 { get; set; }

    [Column("stage_basis_2")]
    [StringLength(2)]
    public string? StageBasis2 { get; set; }

    [Column("scheme_name_2")]
    [StringLength(128)]
    public string? SchemeName2 { get; set; }

    [StringLength(10)]
    public string? MedOncTitle { get; set; }

    [StringLength(30)]
    public string? MedOncFirstName { get; set; }

    [StringLength(2)]
    public string? MedOncMiddleName { get; set; }

    [StringLength(30)]
    public string? MedOncLastName { get; set; }

    [Column("chemo")]
    [StringLength(20)]
    public string? Chemo { get; set; }
}
