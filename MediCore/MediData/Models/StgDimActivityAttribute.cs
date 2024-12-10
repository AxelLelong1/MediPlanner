using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActivityAttribute", Schema = "DWH")]
public partial class StgDimActivityAttribute
{
    [Column("ctrActivityAttributeSer")]
    public long? CtrActivityAttributeSer { get; set; }
}
