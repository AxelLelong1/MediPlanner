using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimProcedureCode
{
    [StringLength(64)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(32)]
    public string ProcedureCodeType { get; set; } = null!;

    [StringLength(254)]
    public string ProcedureCodeDescription { get; set; } = null!;

    [StringLength(64)]
    public string Description { get; set; } = null!;

    [StringLength(64)]
    public string? ProcedureBillingCode { get; set; }

    public int Complexity { get; set; }

    public int ProcedureCodeRevCount { get; set; }

    public int Exportable { get; set; }

    [Column("ctrProcedureCodeSer")]
    public long CtrProcedureCodeSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;
}
