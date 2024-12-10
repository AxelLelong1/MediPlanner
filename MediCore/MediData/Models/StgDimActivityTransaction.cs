using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActivityTransaction")]
public partial class StgDimActivityTransaction
{
    public long? ActivityInstanceSer { get; set; }
}
