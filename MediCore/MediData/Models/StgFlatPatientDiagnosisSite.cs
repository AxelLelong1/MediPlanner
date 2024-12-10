using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFlatPatientDiagnosisSite", Schema = "DWH")]
public partial class StgFlatPatientDiagnosisSite
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("patient_ser")]
    public long? PatientSer { get; set; }
}
