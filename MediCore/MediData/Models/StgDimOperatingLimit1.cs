using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimOperatingLimit", Schema = "DWH")]
public partial class StgDimOperatingLimit1
{
    public long? OperatingLimitSer { get; set; }
}
