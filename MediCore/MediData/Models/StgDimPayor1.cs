using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPayor", Schema = "DWH")]
public partial class StgDimPayor1
{
    public long? PayorSer { get; set; }
}
