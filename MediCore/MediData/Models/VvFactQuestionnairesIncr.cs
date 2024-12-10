using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactQuestionnairesIncr
{
    [StringLength(3000)]
    public string? PatientResponse { get; set; }

    [Column("ResponseDateTimeID")]
    [StringLength(10)]
    [Unicode(false)]
    public string ResponseDateTimeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ResponseDateTime { get; set; }

    [StringLength(1)]
    public string? ResponseValidEntryIndicator { get; set; }

    [StringLength(1)]
    public string Status { get; set; } = null!;

    [Column("ApprovedDateTimeID")]
    [StringLength(10)]
    [Unicode(false)]
    public string ApprovedDateTimeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    [Column("QuestionnaireDateTimeID")]
    [StringLength(10)]
    [Unicode(false)]
    public string QuestionnaireDateTimeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? QuestionnaireDateTime { get; set; }

    [StringLength(1)]
    public string? ResponseHeaderValidEntryIndicator { get; set; }

    [StringLength(255)]
    public string? TransLogUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransLogDateTime { get; set; }

    [StringLength(255)]
    public string? TransLogModifiedUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransLogModifiedDateTime { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrqstr_name")]
    [StringLength(20)]
    public string? CtrqstrName { get; set; }

    [Column("ctrqstr_id")]
    public int CtrqstrId { get; set; }

    [Column("ctrquestion_id")]
    public int CtrquestionId { get; set; }

    [Column("ctrappr_inst_id")]
    [StringLength(30)]
    public string? CtrapprInstId { get; set; }

    [Column("ctrauthor_stkh_id")]
    [StringLength(20)]
    public string? CtrauthorStkhId { get; set; }

    [Column("ctrappr_userid")]
    [StringLength(255)]
    public string? CtrapprUserid { get; set; }
}
