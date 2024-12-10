﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDepartment", Schema = "DWH")]
public partial class StgDimPatientDepartment
{
    public long? PatientDepartmentSer { get; set; }
}
