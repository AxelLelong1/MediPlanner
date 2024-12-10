using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AgtFormularyId")]
[Table("agt_formulary")]
[Index("UpperAgtName", Name = "nc1_agt_formulary")]
[Index("UpperInstDrugCd", Name = "nc2_agt_formulary")]
[Index("InstId", "UpperAgtName", "DosageForm", "AdmnRoute", Name = "nc3_agt_formulary")]
public partial class AgtFormulary
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agt_formulary_id")]
    public int AgtFormularyId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("upper_agt_name")]
    [StringLength(50)]
    public string UpperAgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int DosageForm { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("strength")]
    [StringLength(15)]
    public string? Strength { get; set; }

    [Column("unit_of_measure")]
    [StringLength(10)]
    public string? UnitOfMeasure { get; set; }

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string? DrugDescId { get; set; }

    [Column("inst_drug_cd")]
    [StringLength(30)]
    public string? InstDrugCd { get; set; }

    [Column("upper_inst_drug_cd")]
    [StringLength(30)]
    public string? UpperInstDrugCd { get; set; }

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

    [Column("round_mthd")]
    public int? RoundMthd { get; set; }

    [Column("round_factor", TypeName = "numeric(11, 4)")]
    public decimal? RoundFactor { get; set; }

    [Column("abs_max_dose", TypeName = "numeric(11, 4)")]
    public decimal? AbsMaxDose { get; set; }

    [Column("max_bsa_dose", TypeName = "numeric(11, 4)")]
    public decimal? MaxBsaDose { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("concentration")]
    [StringLength(15)]
    public string? Concentration { get; set; }

    [Column("default_concentration_ind")]
    [StringLength(1)]
    public string? DefaultConcentrationInd { get; set; }

    [Column("agt_prep_typ")]
    public int? AgtPrepTyp { get; set; }

    [Column("pn_template_id")]
    public int? PnTemplateId { get; set; }

    [Column("pn_inst_id")]
    [StringLength(30)]
    public string? PnInstId { get; set; }

    [InverseProperty("AgtFormulary")]
    public virtual ICollection<AgtFormularyGroupAgt> AgtFormularyGroupAgt { get; set; } = new List<AgtFormularyGroupAgt>();

    [ForeignKey("PnInstId, PnTemplateId")]
    [InverseProperty("AgtFormulary")]
    public virtual PnTemplate? PnTemplate { get; set; }

    [InverseProperty("AgtFormulary")]
    public virtual ICollection<ProductFormularyAgtXref> ProductFormularyAgtXref { get; set; } = new List<ProductFormularyAgtXref>();

    [InverseProperty("AgtFormulary")]
    public virtual ICollection<XrefAgtFormularyDispLoc> XrefAgtFormularyDispLoc { get; set; } = new List<XrefAgtFormularyDispLoc>();
}
