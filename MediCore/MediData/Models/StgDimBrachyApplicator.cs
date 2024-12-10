using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimBrachyApplicator", Schema = "DWH")]
public partial class StgDimBrachyApplicator
{
    [Column("ctrBrachyApplicatorSer")]
    public long? CtrBrachyApplicatorSer { get; set; }
}
