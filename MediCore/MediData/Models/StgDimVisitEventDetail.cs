using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimVisitEventDetail", Schema = "DWH")]
public partial class StgDimVisitEventDetail
{
    [Column("pt_id")]
    [StringLength(30)]
    public string? PtId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("unavl_hdr_id")]
    public int? UnavlHdrId { get; set; }
}
