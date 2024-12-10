using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactInVivoDosimetry")]
public partial class StgFactInVivoDosimetry
{
    public long? InVivoDosimetrySer { get; set; }
}
