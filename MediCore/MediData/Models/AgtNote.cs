using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AgtName", "AgtNoteTyp")]
[Table("agt_note")]
public partial class AgtNote
{
    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Key]
    [Column("agt_note_typ")]
    public int AgtNoteTyp { get; set; }

    [Column("agt_note")]
    public string AgtNote1 { get; set; } = null!;

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

    [ForeignKey("AgtName")]
    [InverseProperty("AgtNote")]
    public virtual AgtName AgtNameNavigation { get; set; } = null!;

    [ForeignKey("AgtNoteTyp")]
    [InverseProperty("AgtNote")]
    public virtual AgtNoteTyp AgtNoteTypNavigation { get; set; } = null!;
}
