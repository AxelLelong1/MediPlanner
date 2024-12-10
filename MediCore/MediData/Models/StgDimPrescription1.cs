using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPrescription", Schema = "DWH")]
public partial class StgDimPrescription1
{
    [Column("ID")]
    public int Id { get; set; }

    public long? PrescriptionSer { get; set; }
}
