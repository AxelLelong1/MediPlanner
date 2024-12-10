using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatient", Schema = "DWH")]
public partial class StgDimPatient1
{
    public long? PatientSer { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
