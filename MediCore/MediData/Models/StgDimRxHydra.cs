using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimRxHydra", Schema = "DWH")]
public partial class StgDimRxHydra
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("rx_id")]
    public int? RxId { get; set; }

    [Column("rx_hydra_id")]
    public int? RxHydraId { get; set; }
}
