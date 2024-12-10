using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimToxicityGradingCriteria", Schema = "DWH")]
public partial class StgDimToxicityGradingCriteria1
{
    [Column("gs_author")]
    public int? GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime? EffDate { get; set; }

    [Column("tr_typ")]
    [StringLength(30)]
    public string? TrTyp { get; set; }

    [Column("tr_comp_name")]
    [StringLength(30)]
    public string? TrCompName { get; set; }

    [Column("tr_grade")]
    public int? TrGrade { get; set; }
}
