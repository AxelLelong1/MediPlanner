using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientUserDefinedLabels")]
public partial class StgDimPatientUserDefinedLabels
{
    public long? PatientSer { get; set; }
}
