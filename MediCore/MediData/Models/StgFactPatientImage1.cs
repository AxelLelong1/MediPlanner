﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientImage", Schema = "DWH")]
public partial class StgFactPatientImage1
{
    public long? PatientSer { get; set; }

    public long? ImageSer { get; set; }
}
