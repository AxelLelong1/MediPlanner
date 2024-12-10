using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "VisitNoteId", "CompSeqNo")]
[Table("pt_pn_comps")]
public partial class PtPnComps
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("visit_note_id")]
    public int VisitNoteId { get; set; }

    [Key]
    [Column("comp_seq_no")]
    public int CompSeqNo { get; set; }

    [Column("tag_name")]
    [StringLength(50)]
    public string TagName { get; set; } = null!;

    [Column("tag_comp_name")]
    [StringLength(50)]
    public string TagCompName { get; set; } = null!;

    [Column("tag_comp_seq_no")]
    public int? TagCompSeqNo { get; set; }

    [Column("tag_text_len")]
    public int TagTextLen { get; set; }

    [Column("valid_ind")]
    [StringLength(1)]
    public string? ValidInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
