using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacGroupId", "FacCompId")]
[Table("xref_fac_group")]
[Index("TypOfTest", Name = "nc1_xref_fac_group")]
[Index("InstId", "FacId", "FacCompId", Name = "nc2_xref_fac_group")]
[Index("InstId", "FacId", "TypOfTest", "CompName", Name = "nc3_xref_fac_group")]
public partial class XrefFacGroup
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_group_id")]
    public int FacGroupId { get; set; }

    [Key]
    [Column("fac_comp_id")]
    public int FacCompId { get; set; }

    [Column("typ_of_test")]
    [StringLength(20)]
    public string? TypOfTest { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Column("comp_order_no")]
    public int? CompOrderNo { get; set; }

    [Column("result_comp_order")]
    public int? ResultCompOrder { get; set; }

    [Column("optional_ind")]
    [StringLength(1)]
    public string? OptionalInd { get; set; }

    [Column("calc_typ")]
    public int? CalcTyp { get; set; }

    [Column("calc_reltn_cd")]
    [StringLength(1)]
    public string? CalcReltnCd { get; set; }

    [Column("calc_group")]
    public int? CalcGroup { get; set; }

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

    [Column("calc_prcs_cd")]
    [StringLength(1)]
    public string? CalcPrcsCd { get; set; }

    [Column("configured_ind")]
    [StringLength(1)]
    public string? ConfiguredInd { get; set; }

    [ForeignKey("InstId, FacId, FacCompId")]
    [InverseProperty("XrefFacGroup")]
    public virtual FacComp FacComp { get; set; } = null!;

    [ForeignKey("InstId, FacId, FacGroupId")]
    [InverseProperty("XrefFacGroup")]
    public virtual FacGroup FacGroup { get; set; } = null!;
}
