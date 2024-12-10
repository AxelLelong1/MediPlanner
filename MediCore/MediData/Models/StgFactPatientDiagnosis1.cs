using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientDiagnosis", Schema = "DWH")]
public partial class StgFactPatientDiagnosis1
{
    [Column("diagnosis_ser")]
    public long? DiagnosisSer { get; set; }

    public long? PatientSer { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
