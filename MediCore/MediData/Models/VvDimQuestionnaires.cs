using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimQuestionnaires
{
    [StringLength(50)]
    public string? QuestionnaireTitle { get; set; }

    [StringLength(1)]
    public string QuestionnaireStatus { get; set; } = null!;

    public int QuestionnaireType { get; set; }

    [StringLength(5)]
    public string? QuestionNumber { get; set; }

    public int? QuestionType { get; set; }

    [StringLength(40)]
    public string? QuestionTag { get; set; }

    [StringLength(3000)]
    public string? QuestionText { get; set; }

    [Column("ctrqstr_name")]
    [StringLength(20)]
    public string? CtrqstrName { get; set; }

    [Column("ctrQuestionId")]
    public int CtrQuestionId { get; set; }
}
