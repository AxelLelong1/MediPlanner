using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_DimDiagnosisCode")]
public partial class StgDimDiagnosisCode
{
    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("icd_cd")]
    [StringLength(32)]
    public string? IcdCd { get; set; }
}
