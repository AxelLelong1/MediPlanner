using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDiseaseResponse", Schema = "DWH")]
public partial class StgDimPatientDiseaseResponse
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("cncr_status_id")]
    public int? CncrStatusId { get; set; }
}
