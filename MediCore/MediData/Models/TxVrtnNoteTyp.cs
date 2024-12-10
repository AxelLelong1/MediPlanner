using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tx_vrtn_note_typ")]
public partial class TxVrtnNoteTyp
{
    [Key]
    [Column("tx_vrtn_note_typ")]
    public int TxVrtnNoteTyp1 { get; set; }

    [Column("tx_vrtn_note_seq")]
    public int TxVrtnNoteSeq { get; set; }

    [Column("tx_vrtn_note_desc")]
    [StringLength(40)]
    public string TxVrtnNoteDesc { get; set; } = null!;

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

    [InverseProperty("TxVrtnNoteTypNavigation")]
    public virtual ICollection<TxVrtnNote> TxVrtnNote { get; set; } = new List<TxVrtnNote>();
}
