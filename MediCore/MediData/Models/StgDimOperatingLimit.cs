using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimOperatingLimit")]
public partial class StgDimOperatingLimit
{
    public long? OperatingLimitSer { get; set; }
}
