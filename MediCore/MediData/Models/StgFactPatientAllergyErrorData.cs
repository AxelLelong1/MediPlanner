using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientAllergyErrorData", Schema = "DWH")]
public partial class StgFactPatientAllergyErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("allergy_id")]
    public int? AllergyId { get; set; }
}
