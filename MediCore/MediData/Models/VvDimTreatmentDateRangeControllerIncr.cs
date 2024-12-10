using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimTreatmentDateRangeControllerIncr
{
    [Column(TypeName = "datetime")]
    public DateTime TreatmentDateTime { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrTreatmentRecordSer")]
    public long CtrTreatmentRecordSer { get; set; }
}
