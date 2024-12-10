using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyPatientRtstatusTrackings
{
    public long PatientSer { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string StatusType { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    public DateTime? LastObjectDate { get; set; }
}
