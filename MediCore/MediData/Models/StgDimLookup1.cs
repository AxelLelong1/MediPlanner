using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimLookup", Schema = "DWH")]
public partial class StgDimLookup1
{
    public long? LookupTableSer { get; set; }
}
