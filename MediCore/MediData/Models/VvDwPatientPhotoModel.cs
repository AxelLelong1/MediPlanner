using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientPhotoModel
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public byte[]? Picture { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }
}
