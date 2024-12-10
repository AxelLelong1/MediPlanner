using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtFocusId", "PtFocusStatusId")]
[Table("pt_tp_focus_status")]
public partial class PtTpFocusStatus
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_focus_id")]
    public int PtFocusId { get; set; }

    [Key]
    [Column("pt_focus_status_id")]
    public int PtFocusStatusId { get; set; }

    [Column("focus_status_typ")]
    public int FocusStatusTyp { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

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

    [ForeignKey("FocusStatusTyp")]
    [InverseProperty("PtTpFocusStatus")]
    public virtual FocusStatusTyp FocusStatusTypNavigation { get; set; } = null!;

    [ForeignKey("PtId, PtFocusId")]
    [InverseProperty("PtTpFocusStatus")]
    public virtual PtTpFocus PtTpFocus { get; set; } = null!;
}
