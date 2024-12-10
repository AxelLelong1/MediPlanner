using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatient_ENM", Schema = "DWH")]
public partial class StgFactPatientEnm
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
