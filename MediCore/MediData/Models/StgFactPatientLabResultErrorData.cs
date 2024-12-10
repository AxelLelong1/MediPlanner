using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientLabResultErrorData", Schema = "DWH")]
public partial class StgFactPatientLabResultErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("test_id")]
    public int? TestId { get; set; }

    [Column("test_result_group_id")]
    public int? TestResultGroupId { get; set; }

    [Column("test_result_id")]
    public int? TestResultId { get; set; }
}
