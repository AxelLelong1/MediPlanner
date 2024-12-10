using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GsAuthor", "EffDate", "TrTyp")]
[Table("tr_typ_author")]
public partial class TrTypAuthor
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

    [Column("conflict_mthd")]
    public int ConflictMthd { get; set; }

    [Column("gnrc_tr_typ")]
    [StringLength(30)]
    public string? GnrcTrTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("GnrcTrTyp")]
    [InverseProperty("TrTypAuthor")]
    public virtual TrTyp? GnrcTrTypNavigation { get; set; }

    [InverseProperty("TrTypAuthor")]
    public virtual ICollection<TrComp> TrComp { get; set; } = new List<TrComp>();
}
