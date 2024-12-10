using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactRxDispensary", Schema = "DWH")]
public partial class StgFactRxDispensary
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("rx_id")]
    public int? RxId { get; set; }

    [Column("item_no")]
    public int? ItemNo { get; set; }

    [Column("disp_id")]
    public int? DispId { get; set; }
}
