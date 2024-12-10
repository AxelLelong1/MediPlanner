using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimClinic", Schema = "DWH")]
public partial class StgDimClinic
{
    [Column("Inst_id")]
    [StringLength(60)]
    public string? InstId { get; set; }

    [Column("clinic_id")]
    public int? ClinicId { get; set; }
}
