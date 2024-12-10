using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActivityTransactionErrorData", Schema = "DWH")]
public partial class StgDimActivityTransactionErrorData
{
    public long? ActivityInstanceSer { get; set; }

    public long? PatientSer { get; set; }
}
