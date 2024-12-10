using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPrescriptionErrorData", Schema = "DWH")]
public partial class StgFactPrescriptionErrorData
{
    public long? PrescriptionSer { get; set; }

    public long? PatientSer { get; set; }
}
