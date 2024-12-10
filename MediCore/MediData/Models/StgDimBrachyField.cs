using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimBrachyField", Schema = "DWH")]
public partial class StgDimBrachyField
{
    [Column("ctrRadiationSer")]
    public long? CtrRadiationSer { get; set; }
}
