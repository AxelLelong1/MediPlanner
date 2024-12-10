using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimCellTypeEnm
{
    [StringLength(1)]
    public string? CellTypeBehaviorCode { get; set; }

    public int ClsSchemeId { get; set; }

    [StringLength(4)]
    public string? MorphCode { get; set; }

    public int MorphCodeSequence { get; set; }

    [StringLength(16)]
    public string? VarisHistologyCode { get; set; }

    [Column("CellTypeENU")]
    [StringLength(100)]
    public string? CellTypeEnu { get; set; }

    [Column("CellTypeFRA")]
    [StringLength(100)]
    public string? CellTypeFra { get; set; }

    [Column("CellTypeESN")]
    [StringLength(100)]
    public string? CellTypeEsn { get; set; }

    [Column("CellTypeCHS")]
    [StringLength(100)]
    public string? CellTypeChs { get; set; }

    [Column("CellTypeDEU")]
    [StringLength(100)]
    public string? CellTypeDeu { get; set; }

    [Column("CellTypeITA")]
    [StringLength(100)]
    public string? CellTypeIta { get; set; }

    [Column("CellTypeJPN")]
    [StringLength(100)]
    public string? CellTypeJpn { get; set; }

    [Column("CellTypePTB")]
    [StringLength(100)]
    public string? CellTypePtb { get; set; }

    [Column("CellTypeSVE")]
    [StringLength(100)]
    public string? CellTypeSve { get; set; }
}
