using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactRxAdminDetail", Schema = "DWH")]
public partial class StgFactRxAdminDetail
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("admn_id")]
    public int? AdmnId { get; set; }

    [Column("admn_detail_id")]
    public int? AdmnDetailId { get; set; }
}
