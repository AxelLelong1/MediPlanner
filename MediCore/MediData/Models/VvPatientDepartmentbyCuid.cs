using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPatientDepartmentbyCuid
{
    public long PatientDepartmentSer { get; set; }

    public long PatientSer { get; set; }

    [Column("UserCUID")]
    [StringLength(64)]
    public string UserCuid { get; set; } = null!;

    [StringLength(25)]
    public string PatientId { get; set; } = null!;
}
