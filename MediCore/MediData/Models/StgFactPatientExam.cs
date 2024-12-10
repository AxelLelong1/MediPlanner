using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientExam", Schema = "DWH")]
public partial class StgFactPatientExam
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("pt_exam_id")]
    public int? PtExamId { get; set; }

    [Column("pt_exam_system_id")]
    public int? PtExamSystemId { get; set; }
}
