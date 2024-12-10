using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientPerformanceStatusErrorData", Schema = "DWH")]
public partial class StgDimPatientPerformanceStatusErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("dx_status_id")]
    public int? DxStatusId { get; set; }
}
