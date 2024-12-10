using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactActivityCaptureAttribute", Schema = "DWH")]
public partial class StgFactActivityCaptureAttribute
{
    [Column("ctrActivityCaptureAttributeSer")]
    public long? CtrActivityCaptureAttributeSer { get; set; }
}
