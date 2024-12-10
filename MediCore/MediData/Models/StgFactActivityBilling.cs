using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactActivityBilling")]
public partial class StgFactActivityBilling
{
    public long? ActivityInstanceSer { get; set; }
}
