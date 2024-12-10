using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimLocation", Schema = "DWH")]
public partial class StgDimLocation1
{
    public long? AddressSer { get; set; }
}
