using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "HxCompCatId", "HxCompId")]
[Table("inst_hx_comp_cat_comp")]
public partial class InstHxCompCatComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("hx_comp_cat_id")]
    public int HxCompCatId { get; set; }

    [Key]
    [Column("hx_comp_id")]
    public int HxCompId { get; set; }

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

    [ForeignKey("InstId, HxCompId")]
    [InverseProperty("InstHxCompCatComp")]
    public virtual InstHxComp InstHxComp { get; set; } = null!;

    [ForeignKey("InstId, HxCompCatId")]
    [InverseProperty("InstHxCompCatComp")]
    public virtual InstHxCompCat InstHxCompCat { get; set; } = null!;
}
