using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientUserDefinedLabelsErrorData", Schema = "DWH")]
public partial class StgDimPatientUserDefinedLabelsErrorData
{
    public long? PatientSer { get; set; }
}
