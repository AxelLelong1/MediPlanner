using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimMedoncPlan", Schema = "DWH")]
public partial class StgDimMedoncPlan
{
    [Column("tp_name")]
    [StringLength(40)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(20)]
    public string? TpVersNo { get; set; }
}
