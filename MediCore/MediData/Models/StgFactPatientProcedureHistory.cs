using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientProcedureHistory", Schema = "DWH")]
public partial class StgFactPatientProcedureHistory
{
    [Column("procedure_id")]
    public int? ProcedureId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
