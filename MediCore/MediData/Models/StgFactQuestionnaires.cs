using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactQuestionnaires", Schema = "DWH")]
public partial class StgFactQuestionnaires
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("qstr_name")]
    [StringLength(20)]
    public string? QstrName { get; set; }

    [Column("qstr_id")]
    public int? QstrId { get; set; }

    [Column("question_id")]
    public int? QuestionId { get; set; }
}
