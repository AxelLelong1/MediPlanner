using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDepartmentbyCUID")]
public partial class StgDimPatientDepartmentbyCuid
{
    public long? PatientSer { get; set; }
}
