using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimIcdositeEnm
{
    [Column("ICDOSiteCodeId")]
    [StringLength(3)]
    public string? IcdositeCodeId { get; set; }

    [Column("ICDOSequence")]
    public int Icdosequence { get; set; }

    [Column("ICDOClsSchemeId")]
    public int IcdoclsSchemeId { get; set; }

    [Column("ICDOSiteCodeENU")]
    [StringLength(100)]
    public string? IcdositeCodeEnu { get; set; }

    [Column("ICDOSiteCodeFRA")]
    [StringLength(100)]
    public string? IcdositeCodeFra { get; set; }

    [Column("ICDOSiteCodeESN")]
    [StringLength(100)]
    public string? IcdositeCodeEsn { get; set; }

    [Column("ICDOSiteCodeCHS")]
    [StringLength(100)]
    public string? IcdositeCodeChs { get; set; }

    [Column("ICDOSiteCodeDEU")]
    [StringLength(100)]
    public string? IcdositeCodeDeu { get; set; }

    [Column("ICDOSiteCodeITA")]
    [StringLength(100)]
    public string? IcdositeCodeIta { get; set; }

    [Column("ICDOSiteCodeJPN")]
    [StringLength(100)]
    public string? IcdositeCodeJpn { get; set; }

    [Column("ICDOSiteCodePTB")]
    [StringLength(100)]
    public string? IcdositeCodePtb { get; set; }

    [Column("ICDOSiteCodeSVE")]
    [StringLength(100)]
    public string? IcdositeCodeSve { get; set; }

    [Column("ICDOVersionENU")]
    [StringLength(255)]
    public string? IcdoversionEnu { get; set; }

    [Column("ICDOVersionFRA")]
    [StringLength(255)]
    public string? IcdoversionFra { get; set; }

    [Column("ICDOVersionESN")]
    [StringLength(255)]
    public string? IcdoversionEsn { get; set; }

    [Column("ICDOVersionCHS")]
    [StringLength(255)]
    public string? IcdoversionChs { get; set; }

    [Column("ICDOVersionDEU")]
    [StringLength(255)]
    public string? IcdoversionDeu { get; set; }

    [Column("ICDOVersionITA")]
    [StringLength(255)]
    public string? IcdoversionIta { get; set; }

    [Column("ICDOVersionJPN")]
    [StringLength(255)]
    public string? IcdoversionJpn { get; set; }

    [Column("ICDOVersionPTB")]
    [StringLength(255)]
    public string? IcdoversionPtb { get; set; }

    [Column("ICDOVersionSVE")]
    [StringLength(255)]
    public string? IcdoversionSve { get; set; }
}
