using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GsAuthor", "EffDate", "TrTyp", "TrCompName", "TrSubCompName")]
[Table("gs_tr_sub_comp")]
[Index("ClsSchemeId", Name = "nc1_gs_tr_sub_comp")]
[Index("TrSubCompId", Name = "nc2_gs_tr_sub_comp")]
public partial class GsTrSubComp
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

    [Column("tr_sub_comp_group")]
    [StringLength(40)]
    public string? TrSubCompGroup { get; set; }

    [Key]
    [Column("tr_sub_comp_name")]
    [StringLength(60)]
    public string TrSubCompName { get; set; } = null!;

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

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("tr_sub_comp_id")]
    public int? TrSubCompId { get; set; }

    [ForeignKey("GsAuthor, EffDate, TrTyp, TrCompName")]
    [InverseProperty("GsTrSubComp")]
    public virtual TrComp TrComp { get; set; } = null!;
}
