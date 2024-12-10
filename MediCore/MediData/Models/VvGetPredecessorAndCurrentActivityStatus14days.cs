using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetPredecessorAndCurrentActivityStatus14days
{
    public long PredecessorSer { get; set; }

    [Column("ctrScheduledActivitySer")]
    public long CtrScheduledActivitySer { get; set; }

    [Column("ctrActivityInstanceSer")]
    public long CtrActivityInstanceSer { get; set; }

    public long? PatientSer { get; set; }

    [StringLength(64)]
    public string? CurrentActivityAppointmentStatus { get; set; }

    [StringLength(64)]
    public string? ParentActivityAppointmentStatus { get; set; }

    [StringLength(64)]
    public string? DerivedActivityStatus { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsScheduledActivity { get; set; } = null!;
}
