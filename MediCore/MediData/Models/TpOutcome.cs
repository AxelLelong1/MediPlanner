using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "OutcomeId")]
[Table("tp_outcome")]
public partial class TpOutcome
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("outcome_id")]
    public int OutcomeId { get; set; }

    [Column("outcome_desc")]
    [StringLength(255)]
    public string OutcomeDesc { get; set; } = null!;

    [Column("focus_id")]
    public int? FocusId { get; set; }

    [Column("intv_cat_id")]
    public int? IntvCatId { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("outcome_seq")]
    public int? OutcomeSeq { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

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

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("TpOutcome")]
    public virtual ICollection<TpEval> TpEval { get; set; } = new List<TpEval>();

    [ForeignKey("TpName, TpVersNo, FocusId")]
    [InverseProperty("TpOutcome")]
    public virtual TpFocus? TpFocus { get; set; }

    [ForeignKey("TpName, TpVersNo, IntvCatId")]
    [InverseProperty("TpOutcome")]
    public virtual TpIntvCat? TpIntvCat { get; set; }
}
