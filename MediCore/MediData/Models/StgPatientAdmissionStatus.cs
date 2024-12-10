using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgPatientAdmissionStatus", Schema = "DWH")]
public partial class StgPatientAdmissionStatus
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }
}
