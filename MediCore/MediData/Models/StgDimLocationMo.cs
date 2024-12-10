using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimLocation_MO", Schema = "DWH")]
public partial class StgDimLocationMo
{
    [Column("country_desc")]
    [StringLength(80)]
    public string? CountryDesc { get; set; }

    [Column("prv_state")]
    [StringLength(60)]
    public string? PrvState { get; set; }

    [Column("city")]
    [StringLength(60)]
    public string? City { get; set; }

    [Column("pc_zip")]
    [StringLength(20)]
    public string? PcZip { get; set; }

    [Column("county")]
    [StringLength(60)]
    public string? County { get; set; }
}
