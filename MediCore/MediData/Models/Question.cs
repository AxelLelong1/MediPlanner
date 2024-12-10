using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("QstrName", "QuestionId")]
[Table("question")]
public partial class Question
{
    [Key]
    [Column("qstr_name")]
    [StringLength(20)]
    public string QstrName { get; set; } = null!;

    [Key]
    [Column("question_id")]
    public int QuestionId { get; set; }

    [Column("question_no")]
    [StringLength(5)]
    public string? QuestionNo { get; set; }

    [Column("question_typ")]
    public int? QuestionTyp { get; set; }

    [Column("no_attr_1", TypeName = "decimal(11, 4)")]
    public decimal? NoAttr1 { get; set; }

    [Column("no_attr_2", TypeName = "decimal(11, 4)")]
    public decimal? NoAttr2 { get; set; }

    [Column("no_attr_3", TypeName = "decimal(11, 4)")]
    public decimal? NoAttr3 { get; set; }

    [Column("string_attr_1")]
    [StringLength(20)]
    public string? StringAttr1 { get; set; }

    [Column("string_attr_2")]
    [StringLength(20)]
    public string? StringAttr2 { get; set; }

    [Column("string_attr_3")]
    public string? StringAttr3 { get; set; }

    [Column("question_txt")]
    public string? QuestionTxt { get; set; }

    [Column("ind_attr_1")]
    [StringLength(1)]
    public string? IndAttr1 { get; set; }

    [Column("ind_attr_2")]
    [StringLength(1)]
    public string? IndAttr2 { get; set; }

    [Column("ind_attr_3")]
    [StringLength(1)]
    public string? IndAttr3 { get; set; }

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

    [Column("question_share_ind")]
    [StringLength(1)]
    public string? QuestionShareInd { get; set; }

    [Column("question_tag")]
    [StringLength(40)]
    public string? QuestionTag { get; set; }

    [Column("question_tag_tstamp", TypeName = "datetime")]
    public DateTime? QuestionTagTstamp { get; set; }

    [Column("score_values")]
    [StringLength(200)]
    public string? ScoreValues { get; set; }

    [Column("req_ind")]
    [StringLength(1)]
    public string? ReqInd { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [ForeignKey("QstrName")]
    [InverseProperty("Question")]
    public virtual Qstr QstrNameNavigation { get; set; } = null!;

    [ForeignKey("QuestionTyp")]
    [InverseProperty("Question")]
    public virtual QuestionTyp? QuestionTypNavigation { get; set; }
}
