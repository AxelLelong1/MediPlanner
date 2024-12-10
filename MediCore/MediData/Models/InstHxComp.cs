using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "HxCompId")]
[Table("inst_hx_comp")]
public partial class InstHxComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("hx_comp_id")]
    public int HxCompId { get; set; }

    [Column("hx_comp_desc")]
    [StringLength(255)]
    public string HxCompDesc { get; set; } = null!;

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("med_cd")]
    [StringLength(1)]
    public string? MedCd { get; set; }

    [Column("med_hx_ind")]
    [StringLength(1)]
    public string? MedHxInd { get; set; }

    [Column("fam_hx_ind")]
    [StringLength(1)]
    public string? FamHxInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("procedure_age")]
    public int? ProcedureAge { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("dx_cd")]
    [StringLength(20)]
    public string? DxCd { get; set; }

    [InverseProperty("InstHxComp")]
    public virtual ICollection<InstHxCompCatComp> InstHxCompCatComp { get; set; } = new List<InstHxCompCatComp>();
}
