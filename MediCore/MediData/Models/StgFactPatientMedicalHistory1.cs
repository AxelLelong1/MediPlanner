using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientMedicalHistory", Schema = "DWH")]
public partial class StgFactPatientMedicalHistory1
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
