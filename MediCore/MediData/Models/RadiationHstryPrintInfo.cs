using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("RadiationHstryPrintInfo", Schema = "DWH")]
public partial class RadiationHstryPrintInfo
{
    public long PatientSer { get; set; }

    public long CourseSer { get; set; }

    public long CheckSumValue { get; set; }

    public byte PrintFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }
}
