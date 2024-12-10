using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgRegistration")]
public partial class StgRegistration
{
    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }
}
