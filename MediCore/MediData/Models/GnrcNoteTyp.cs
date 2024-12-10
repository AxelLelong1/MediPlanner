using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("gnrc_note_typ")]
public partial class GnrcNoteTyp
{
    [Key]
    [Column("gnrc_note_typ")]
    public int GnrcNoteTyp1 { get; set; }

    [Column("gnrc_note_tbl")]
    [StringLength(30)]
    public string GnrcNoteTbl { get; set; } = null!;

    [Column("gnrc_note_col")]
    [StringLength(30)]
    public string GnrcNoteCol { get; set; } = null!;

    [Column("gnrc_note_desc")]
    [StringLength(40)]
    public string GnrcNoteDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [InverseProperty("GnrcNoteTypNavigation")]
    public virtual ICollection<GnrcNote> GnrcNote { get; set; } = new List<GnrcNote>();
}
