using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GsAuthor", "EffDate")]
[Table("grading_schemes")]
public partial class GradingSchemes
{
    [Key]
    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("gs_typ")]
    [StringLength(1)]
    public string GsTyp { get; set; } = null!;

    [Column("gs_desc")]
    [StringLength(40)]
    public string? GsDesc { get; set; }

    [Column("original_gs_author")]
    public int? OriginalGsAuthor { get; set; }

    [Column("original_eff_date", TypeName = "datetime")]
    public DateTime? OriginalEffDate { get; set; }

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

    [ForeignKey("GsAuthor")]
    [InverseProperty("GradingSchemesGsAuthorNavigation")]
    public virtual Spsr GsAuthorNavigation { get; set; } = null!;

    [ForeignKey("OriginalGsAuthor")]
    [InverseProperty("GradingSchemesOriginalGsAuthorNavigation")]
    public virtual Spsr? OriginalGsAuthorNavigation { get; set; }
}
