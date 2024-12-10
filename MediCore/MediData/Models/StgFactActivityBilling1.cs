using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactActivityBilling", Schema = "DWH")]
public partial class StgFactActivityBilling1
{
    public long? ActivityInstanceSer { get; set; }

    public long? PatientSer { get; set; }
}
