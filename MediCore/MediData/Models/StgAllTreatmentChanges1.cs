using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgAllTreatmentChanges", Schema = "DWH")]
public partial class StgAllTreatmentChanges1
{
    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }

    public long? PlanSetupSer { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    public int? Status { get; set; }
}
