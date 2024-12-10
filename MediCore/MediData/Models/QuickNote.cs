using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "QuickNoteId")]
[Table("quick_note")]
public partial class QuickNote
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("quick_note_id")]
    public int QuickNoteId { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string ApprFlag { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("author_userid")]
    [StringLength(255)]
    public string AuthorUserid { get; set; } = null!;

    [Column("author_inst_id")]
    [StringLength(30)]
    public string AuthorInstId { get; set; } = null!;

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("note_tstamp", TypeName = "datetime")]
    public DateTime? NoteTstamp { get; set; }

    [Column("quick_note_text")]
    public string? QuickNoteText { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("quick_note_typ")]
    public int? QuickNoteTyp { get; set; }

    [ForeignKey("QuickNoteTyp")]
    [InverseProperty("QuickNote")]
    public virtual QuickNoteTyp? QuickNoteTypNavigation { get; set; }
}
