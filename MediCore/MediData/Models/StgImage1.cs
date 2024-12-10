using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgImage", Schema = "DWH")]
[Index("Id", Name = "stgImage_NCIX1")]
public partial class StgImage1
{
    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    public int? Status { get; set; }
}
