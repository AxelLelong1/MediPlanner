using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientFamilyHistoryErrorData", Schema = "DWH")]
public partial class StgFactPatientFamilyHistoryErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("fam_hx_id")]
    public int? FamHxId { get; set; }
}
