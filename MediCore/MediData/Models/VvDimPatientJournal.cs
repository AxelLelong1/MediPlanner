using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientJournal
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("quick_note_id")]
    public int QuickNoteId { get; set; }

    [StringLength(1)]
    public string ApprovedFlag { get; set; } = null!;

    [Column("author_userid")]
    [StringLength(255)]
    public string? AuthorUserid { get; set; }

    [Column("author_inst_id")]
    [StringLength(30)]
    public string? AuthorInstId { get; set; }

    [Column("DimDateID_Journal")]
    public long? DimDateIdJournal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JournalDate { get; set; }

    [StringLength(3000)]
    public string? JournalText { get; set; }

    [StringLength(255)]
    public string JournalTypeDescription { get; set; } = null!;

    [StringLength(255)]
    public string? JournalErrorReasonText { get; set; }

    public int? JournalRevisionNumber { get; set; }

    [StringLength(1)]
    public string JournalValidEntryIndicator { get; set; } = null!;
}
