using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimICDOSite", Schema = "DWH")]
public partial class StgDimIcdosite1
{
    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string? IcdoSiteCd { get; set; }

    [Column("icdo_site_seq")]
    public int? IcdoSiteSeq { get; set; }

    [Column("culture_cd")]
    [StringLength(10)]
    public string? CultureCd { get; set; }
}
