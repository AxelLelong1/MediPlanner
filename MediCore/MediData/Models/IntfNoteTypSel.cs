using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_note_typ_sel")]
public partial class IntfNoteTypSel
{
    [Key]
    [Column("intf_note_typ_id")]
    public int IntfNoteTypId { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("note_typ")]
    public int? NoteTyp { get; set; }

    [Column("note_txt")]
    [StringLength(255)]
    public string? NoteTxt { get; set; }

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

    [Column("note_name")]
    [StringLength(30)]
    public string? NoteName { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfNoteTypSel")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;
}
