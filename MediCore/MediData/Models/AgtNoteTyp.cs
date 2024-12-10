using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_note_typ")]
public partial class AgtNoteTyp
{
    [Key]
    [Column("agt_note_typ")]
    public int AgtNoteTyp1 { get; set; }

    [Column("agt_note_seq")]
    public int AgtNoteSeq { get; set; }

    [Column("agt_note_desc")]
    [StringLength(40)]
    public string AgtNoteDesc { get; set; } = null!;

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

    [InverseProperty("AgtNoteTypNavigation")]
    public virtual ICollection<AgtNote> AgtNote { get; set; } = new List<AgtNote>();
}
