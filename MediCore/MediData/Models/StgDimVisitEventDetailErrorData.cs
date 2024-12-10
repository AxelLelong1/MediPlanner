using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimVisitEventDetailErrorData", Schema = "DWH")]
public partial class StgDimVisitEventDetailErrorData
{
    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("unavl_hdr_id")]
    public int? UnavlHdrId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
