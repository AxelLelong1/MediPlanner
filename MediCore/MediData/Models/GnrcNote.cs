using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "GnrcNoteId")]
[Table("gnrc_note")]
public partial class GnrcNote
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("gnrc_note_id")]
    public int GnrcNoteId { get; set; }

    [Column("gnrc_note_typ")]
    public int GnrcNoteTyp { get; set; }

    [Column("gnrc_note_txt")]
    [StringLength(255)]
    public string GnrcNoteTxt { get; set; } = null!;

    [Column("gnrc_note_short_desc")]
    [StringLength(40)]
    public string GnrcNoteShortDesc { get; set; } = null!;

    [Column("cr_ind")]
    [StringLength(1)]
    public string? CrInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [ForeignKey("GnrcNoteTyp")]
    [InverseProperty("GnrcNote")]
    public virtual GnrcNoteTyp GnrcNoteTypNavigation { get; set; } = null!;

    [ForeignKey("InstId")]
    [InverseProperty("GnrcNote")]
    public virtual Inst Inst { get; set; } = null!;
}
