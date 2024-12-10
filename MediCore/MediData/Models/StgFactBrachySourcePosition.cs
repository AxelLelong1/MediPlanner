using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactBrachySourcePosition", Schema = "DWH")]
public partial class StgFactBrachySourcePosition
{
    [Column("ctrSourcePositionSer")]
    public long? CtrSourcePositionSer { get; set; }
}
