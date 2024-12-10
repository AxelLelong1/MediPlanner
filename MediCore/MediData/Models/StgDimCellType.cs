using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimCellType")]
public partial class StgDimCellType
{
    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("morph_cd")]
    [StringLength(4)]
    public string? MorphCd { get; set; }

    [Column("behavior_cd")]
    [StringLength(1)]
    public string? BehaviorCd { get; set; }

    [Column("morph_cd_seq")]
    public int? MorphCdSeq { get; set; }

    [Column("culture_cd")]
    [StringLength(10)]
    public string? CultureCd { get; set; }
}
