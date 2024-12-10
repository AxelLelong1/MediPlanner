using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtFocusId")]
[Table("pt_tp_focus")]
public partial class PtTpFocus
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("pt_focus_id")]
    public int PtFocusId { get; set; }

    [Column("focus_desc")]
    [StringLength(255)]
    public string FocusDesc { get; set; } = null!;

    [Column("focus_seq")]
    public int? FocusSeq { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("PtTpFocus")]
    public virtual ICollection<PtTpFocusStatus> PtTpFocusStatus { get; set; } = new List<PtTpFocusStatus>();

    [InverseProperty("PtTpFocus")]
    public virtual ICollection<PtTpOutcome> PtTpOutcome { get; set; } = new List<PtTpOutcome>();

    [InverseProperty("PtTpFocus")]
    public virtual ICollection<VisitNote> VisitNote { get; set; } = new List<VisitNote>();
}
