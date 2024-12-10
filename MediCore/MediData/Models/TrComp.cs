using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GsAuthor", "EffDate", "TrTyp", "TrCompName")]
[Table("tr_comp")]
[Index("ClsSchemeId", Name = "nc1_tr_comp")]
[Index("TrCompId", Name = "nc2_tr_comp")]
public partial class TrComp
{
    [Key]
    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Key]
    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Key]
    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName { get; set; } = null!;

    [Column("gnrc_tr_typ")]
    [StringLength(30)]
    public string GnrcTrTyp { get; set; } = null!;

    [Column("gnrc_tr_comp_name")]
    [StringLength(30)]
    public string GnrcTrCompName { get; set; } = null!;

    [Column("asmt_mthd")]
    public int AsmtMthd { get; set; }

    [Column("tr_units")]
    public int? TrUnits { get; set; }

    [Column("tr_operator")]
    public int? TrOperator { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("tox_death_ind")]
    [StringLength(1)]
    public string? ToxDeathInd { get; set; }

    [Column("tr_sub_comp_ind")]
    [StringLength(1)]
    public string? TrSubCompInd { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("tr_comp_id")]
    public int? TrCompId { get; set; }

    [Column("pt_comp_desc")]
    [StringLength(100)]
    public string? PtCompDesc { get; set; }

    [Column("meddra_cd")]
    public int? MeddraCd { get; set; }

    [ForeignKey("AsmtMthd")]
    [InverseProperty("TrComp")]
    public virtual AsmtMthd AsmtMthdNavigation { get; set; } = null!;

    [InverseProperty("TrComp")]
    public virtual ICollection<GradingCriteria> GradingCriteria { get; set; } = new List<GradingCriteria>();

    [InverseProperty("TrComp")]
    public virtual ICollection<GsTrSubComp> GsTrSubComp { get; set; } = new List<GsTrSubComp>();

    [InverseProperty("TrComp")]
    public virtual ICollection<TrAsmt> TrAsmt { get; set; } = new List<TrAsmt>();

    [ForeignKey("GnrcTrTyp, GnrcTrCompName")]
    [InverseProperty("TrComp")]
    public virtual TrCompName TrCompNameNavigation { get; set; } = null!;

    [ForeignKey("GsAuthor, EffDate, TrTyp")]
    [InverseProperty("TrComp")]
    public virtual TrTypAuthor TrTypAuthor { get; set; } = null!;

    [ForeignKey("TrUnits")]
    [InverseProperty("TrComp")]
    public virtual UnitOfMeas? TrUnitsNavigation { get; set; }

    [InverseProperty("TrComp")]
    public virtual ICollection<XrefTrTypPln> XrefTrTypPln { get; set; } = new List<XrefTrTypPln>();
}
