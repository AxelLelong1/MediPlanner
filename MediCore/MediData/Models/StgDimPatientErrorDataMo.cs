using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientErrorData_MO", Schema = "DWH")]
public partial class StgDimPatientErrorDataMo
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
