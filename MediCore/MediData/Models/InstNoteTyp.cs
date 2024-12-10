using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "NoteTyp")]
[Table("inst_note_typ")]
public partial class InstNoteTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("note_typ")]
    public int NoteTyp { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

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

    [Column("print_header_ind")]
    [StringLength(1)]
    public string? PrintHeaderInd { get; set; }

    [Column("print_margin_ind")]
    [StringLength(1)]
    public string? PrintMarginInd { get; set; }

    [Column("print_left_margin_val", TypeName = "numeric(5, 2)")]
    public decimal? PrintLeftMarginVal { get; set; }

    [Column("print_right_margin_val", TypeName = "numeric(5, 2)")]
    public decimal? PrintRightMarginVal { get; set; }

    [Column("print_top_margin_val", TypeName = "numeric(5, 2)")]
    public decimal? PrintTopMarginVal { get; set; }

    [Column("print_bottom_margin_val", TypeName = "numeric(5, 2)")]
    public decimal? PrintBottomMarginVal { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("fs_display_ind")]
    [StringLength(1)]
    public string? FsDisplayInd { get; set; }

    [Column("favorite_ind")]
    [StringLength(1)]
    public string? FavoriteInd { get; set; }

    [ForeignKey("NoteTyp")]
    [InverseProperty("InstNoteTyp")]
    public virtual NoteTyp NoteTypNavigation { get; set; } = null!;
}
