using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimAddOn", Schema = "DWH")]
public partial class StgDimAddOn1
{
    public long? AddOnSer { get; set; }
}
