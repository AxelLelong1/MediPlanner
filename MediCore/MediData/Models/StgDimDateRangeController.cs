using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimDateRangeController")]
public partial class StgDimDateRangeController
{
    public long? ScheduledActivitySer { get; set; }
}
