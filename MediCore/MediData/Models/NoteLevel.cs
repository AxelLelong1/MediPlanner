using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("note_level")]
public partial class NoteLevel
{
    [Key]
    [Column("note_level")]
    public int NoteLevel1 { get; set; }

    [Column("note_level_desc")]
    [StringLength(40)]
    public string NoteLevelDesc { get; set; } = null!;

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

    [InverseProperty("NoteLevelNavigation")]
    public virtual ICollection<VisitNote> VisitNote { get; set; } = new List<VisitNote>();
}
