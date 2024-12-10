using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientDoctor
{
    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    public int PrimaryFlag { get; set; }

    public int OncologistFlag { get; set; }
}
