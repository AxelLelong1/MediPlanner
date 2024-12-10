using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgBrachyPatientSer", Schema = "DWH")]
public partial class StgBrachyPatientSer
{
    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }
}
