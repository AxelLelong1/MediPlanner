using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimChannel", Schema = "DWH")]
public partial class StgDimChannel
{
    [Column("ctrChannelSer")]
    public long? CtrChannelSer { get; set; }
}
