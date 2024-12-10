using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TpName", "DateTpInit", "OutcomeId")]
[Table("pt_tp_outcome")]
public partial class PtTpOutcome
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("outcome_id")]
    public int OutcomeId { get; set; }

    [Column("outcome_desc")]
    [StringLength(255)]
    public string OutcomeDesc { get; set; } = null!;

    [Column("pt_focus_id")]
    public int? PtFocusId { get; set; }

    [Column("intv_cat_id")]
    public int? IntvCatId { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("outcome_seq")]
    public int? OutcomeSeq { get; set; }

    [Column("individualized_ind")]
    [StringLength(1)]
    public string IndividualizedInd { get; set; } = null!;

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

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("PtTpOutcome")]
    public virtual ICollection<PtTpEval> PtTpEval { get; set; } = new List<PtTpEval>();

    [ForeignKey("PtId, PtFocusId")]
    [InverseProperty("PtTpOutcome")]
    public virtual PtTpFocus? PtTpFocus { get; set; }
}
