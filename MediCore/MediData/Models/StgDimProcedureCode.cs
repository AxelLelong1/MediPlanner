using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimProcedureCode")]
public partial class StgDimProcedureCode
{
    public long? ProcedureCodeSer { get; set; }

    public int? ProcedureCodeRevCount { get; set; }
}
