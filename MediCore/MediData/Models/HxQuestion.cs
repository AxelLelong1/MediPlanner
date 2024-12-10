using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("HdrTyp", "QuestionNo")]
[Table("hx_question")]
public partial class HxQuestion
{
    [Key]
    [Column("hdr_typ")]
    public int HdrTyp { get; set; }

    [Key]
    [Column("question_no")]
    public int QuestionNo { get; set; }

    [Column("question")]
    [StringLength(200)]
    public string Question { get; set; } = null!;

    [Column("question_typ")]
    public int QuestionTyp { get; set; }

    [Column("maintain_hx_count")]
    public int MaintainHxCount { get; set; }

    [Column("question_ht")]
    public int? QuestionHt { get; set; }

    [Column("question_radio")]
    [StringLength(200)]
    public string? QuestionRadio { get; set; }

    [Column("question_start")]
    [StringLength(1)]
    public string? QuestionStart { get; set; }

    [Column("question_end")]
    [StringLength(1)]
    public string? QuestionEnd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [ForeignKey("HdrTyp")]
    [InverseProperty("HxQuestion")]
    public virtual HxHdr HdrTypNavigation { get; set; } = null!;

    [InverseProperty("HxQuestion")]
    public virtual ICollection<PtHxResp> PtHxResp { get; set; } = new List<PtHxResp>();
}
