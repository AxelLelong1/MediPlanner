using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActivity", Schema = "DWH")]
public partial class StgDimActivity1
{
    public long? ActivitySer { get; set; }
}
