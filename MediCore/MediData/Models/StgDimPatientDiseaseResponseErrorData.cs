using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDiseaseResponseErrorData", Schema = "DWH")]
public partial class StgDimPatientDiseaseResponseErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("cncr_status_id")]
    public int? CncrStatusId { get; set; }
}
