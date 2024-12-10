using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimQuestionnaires", Schema = "DWH")]
public partial class StgDimQuestionnaires
{
    [Column("qstr_name")]
    [StringLength(20)]
    public string? QstrName { get; set; }

    [Column("question_id")]
    public int? QuestionId { get; set; }
}
