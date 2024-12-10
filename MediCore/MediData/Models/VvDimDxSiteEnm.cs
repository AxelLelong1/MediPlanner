using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimDxSiteEnm
{
    public int TpClsTypeId { get; set; }

    public int TpClsValueId { get; set; }

    [Column("SiteDescENU")]
    [StringLength(100)]
    public string? SiteDescEnu { get; set; }

    [Column("SiteDescFRA")]
    [StringLength(100)]
    public string? SiteDescFra { get; set; }

    [Column("SiteDescESN")]
    [StringLength(100)]
    public string? SiteDescEsn { get; set; }

    [Column("SiteDescCHS")]
    [StringLength(100)]
    public string? SiteDescChs { get; set; }

    [Column("SiteDescDEU")]
    [StringLength(100)]
    public string? SiteDescDeu { get; set; }

    [Column("SiteDescITA")]
    [StringLength(100)]
    public string? SiteDescIta { get; set; }

    [Column("SiteDescJPN")]
    [StringLength(100)]
    public string? SiteDescJpn { get; set; }

    [Column("SiteDescPTB")]
    [StringLength(100)]
    public string? SiteDescPtb { get; set; }

    [Column("SiteDescSVE")]
    [StringLength(100)]
    public string? SiteDescSve { get; set; }
}
