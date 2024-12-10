using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientPhoto", Schema = "DWH")]
public partial class StgDimPatientPhoto1
{
    public long? PhotoSer { get; set; }
}
