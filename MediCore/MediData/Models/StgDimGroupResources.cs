using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimGroupResources", Schema = "DWH")]
public partial class StgDimGroupResources
{
    public long GroupResourceSer { get; set; }
}
