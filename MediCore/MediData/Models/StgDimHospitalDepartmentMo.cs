using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimHospitalDepartment_MO", Schema = "DWH")]
public partial class StgDimHospitalDepartmentMo
{
    [Column("Inst_id")]
    [StringLength(60)]
    public string? InstId { get; set; }
}
