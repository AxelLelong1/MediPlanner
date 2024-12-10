using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgRegistration", Schema = "DWH")]
public partial class StgRegistration1
{
    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }
}
