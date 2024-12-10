using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "EffDate", "SchemeTyp")]
[Table("inst_scheme")]
public partial class InstScheme
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Key]
    [Column("scheme_typ")]
    public int SchemeTyp { get; set; }

    [Column("scheme_author")]
    public int SchemeAuthor { get; set; }

    [Column("scheme_eff_date", TypeName = "datetime")]
    public DateTime SchemeEffDate { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string CurEntryInd { get; set; } = null!;

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

    [Column("inst_eff_date", TypeName = "datetime")]
    public DateTime? InstEffDate { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("InstScheme")]
    public virtual Inst Inst { get; set; } = null!;

    [ForeignKey("SchemeTyp")]
    [InverseProperty("InstScheme")]
    public virtual SchemeTyp SchemeTypNavigation { get; set; } = null!;
}
