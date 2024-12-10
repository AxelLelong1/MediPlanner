using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActivityTransaction", Schema = "DWH")]
public partial class StgDimActivityTransaction1
{
    public long? ActivityInstanceSer { get; set; }

    public long? PatientSer { get; set; }
}
