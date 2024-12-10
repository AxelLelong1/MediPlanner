using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("question_typ")]
public partial class QuestionTyp
{
    [Key]
    [Column("question_typ")]
    public int QuestionTyp1 { get; set; }

    [Column("question_desc")]
    [StringLength(40)]
    public string QuestionDesc { get; set; } = null!;

    [Column("question_max_no_1")]
    public int? QuestionMaxNo1 { get; set; }

    [Column("question_max_no_2")]
    public int? QuestionMaxNo2 { get; set; }

    [Column("question_max_no_3")]
    public int? QuestionMaxNo3 { get; set; }

    [Column("question_min_no_1")]
    public int? QuestionMinNo1 { get; set; }

    [Column("question_min_no_2")]
    public int? QuestionMinNo2 { get; set; }

    [Column("question_min_no_3")]
    public int? QuestionMinNo3 { get; set; }

    [Column("display_ind")]
    [StringLength(1)]
    public string? DisplayInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("question_typ_seq")]
    public int? QuestionTypSeq { get; set; }

    [InverseProperty("QuestionTypNavigation")]
    public virtual ICollection<Question> Question { get; set; } = new List<Question>();
}
