using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyPatientRtstatusImages
{
    public long? PatientSer { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string StatusType { get; set; } = null!;

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [StringLength(30)]
    public string? ObjectType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastObjectDate { get; set; }
}
