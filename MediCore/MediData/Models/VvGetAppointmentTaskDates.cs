using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetAppointmentTaskDates
{
    public long ActivitySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDateTime { get; set; }

    [Column("IsAppointmentORTask")]
    [StringLength(1)]
    [Unicode(false)]
    public string IsAppointmentOrtask { get; set; } = null!;
}
