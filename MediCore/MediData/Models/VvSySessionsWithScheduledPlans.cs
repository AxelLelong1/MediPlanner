using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSySessionsWithScheduledPlans
{
    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long CourseSer { get; set; }

    public long? LastTreatedSessionSer { get; set; }

    public long? FirstActiveSessionSer { get; set; }

    public long? LastTreatedImagedSessionSer { get; set; }

    public long? FirstActiveImagingSessionSer { get; set; }
}
