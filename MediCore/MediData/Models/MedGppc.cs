using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_gppc")]
[Index("Gpi", Name = "nc1_med_gppc")]
public partial class MedGppc
{
    [Key]
    [Column("gppc")]
    [StringLength(8)]
    public string Gppc { get; set; } = null!;

    [Column("pkg_size")]
    [StringLength(9)]
    public string? PkgSize { get; set; }

    [Column("pkg_size_uom")]
    [StringLength(2)]
    public string? PkgSizeUom { get; set; }

    [Column("pkg_quantity")]
    [StringLength(5)]
    public string? PkgQuantity { get; set; }

    [Column("unit_dose")]
    [StringLength(1)]
    public string? UnitDose { get; set; }

    [Column("pkg_desc_cd")]
    [StringLength(2)]
    public string? PkgDescCd { get; set; }

    [Column("gpi")]
    [StringLength(14)]
    public string? Gpi { get; set; }

    [Column("reserve")]
    [StringLength(14)]
    public string? Reserve { get; set; }

    [Column("activity_cd")]
    [StringLength(1)]
    public string? ActivityCd { get; set; }

    [Column("last_chg_date")]
    [StringLength(8)]
    public string? LastChgDate { get; set; }

    [Column("del_flag")]
    [StringLength(1)]
    public string? DelFlag { get; set; }

    [Column("optx_chg_date", TypeName = "datetime")]
    public DateTime? OptxChgDate { get; set; }
}
