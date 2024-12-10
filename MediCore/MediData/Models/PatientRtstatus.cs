using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("PatientRTStatus")]
[Index("PatientSer", "StatusType", Name = "XIE1PatientRTStatus")]
[Index("PatientSer", "LastObjectDate", Name = "XIE2PatientRTStatus")]
public partial class PatientRtstatus
{
    public long PatientSer { get; set; }

    [StringLength(32)]
    public string StatusType { get; set; } = null!;

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [StringLength(32)]
    public string? ObjectType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastObjectDate { get; set; }

    [ForeignKey("PatientSer")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
