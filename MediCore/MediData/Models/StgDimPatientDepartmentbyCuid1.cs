using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDepartmentbyCUID", Schema = "DWH")]
public partial class StgDimPatientDepartmentbyCuid1
{
    public long? PatientSer { get; set; }
}
