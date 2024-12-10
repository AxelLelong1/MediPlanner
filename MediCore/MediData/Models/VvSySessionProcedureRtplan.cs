using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSySessionProcedureRtplan
{
    public long SessionProcedureSer { get; set; }

    [StringLength(16)]
    public string Status { get; set; } = null!;

    public long SessionSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }
}
