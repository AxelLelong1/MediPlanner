using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimRadioactiveModelSource", Schema = "DWH")]
public partial class StgDimRadioactiveModelSource
{
    [Column("ctrRadioactiveSourceSer")]
    public long? CtrRadioactiveSourceSer { get; set; }
}
