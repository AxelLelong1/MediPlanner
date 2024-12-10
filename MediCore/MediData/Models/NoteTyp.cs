using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("note_typ")]
public partial class NoteTyp
{
    [Key]
    [Column("note_typ")]
    public int NoteTyp1 { get; set; }

    [Column("note_typ_desc")]
    [StringLength(40)]
    public string NoteTypDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("document_typ_ser")]
    public int? DocumentTypSer { get; set; }

    [InverseProperty("NoteTypNavigation")]
    public virtual ICollection<InstNoteTyp> InstNoteTyp { get; set; } = new List<InstNoteTyp>();

    [InverseProperty("TemplateTypNavigation")]
    public virtual ICollection<PnUserTemplate> PnUserTemplate { get; set; } = new List<PnUserTemplate>();

    [InverseProperty("NoteTypNavigation")]
    public virtual ICollection<VisitNote> VisitNote { get; set; } = new List<VisitNote>();
}
