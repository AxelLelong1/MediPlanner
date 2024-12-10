using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwDateRangeControllerModel
{
    [StringLength(64)]
    public string ActivityCategory { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDateTime { get; set; }

    public int WaitListedFlag { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }
}
