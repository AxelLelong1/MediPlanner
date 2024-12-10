using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDepartmentbyCUIDErrorData", Schema = "DWH")]
public partial class StgDimPatientDepartmentbyCuiderrorData
{
    public long? PatientSer { get; set; }
}
