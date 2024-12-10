using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ProcedureCodeSer", "ProcedureCodeRevCount")]
[Table("ProcedureCodeMH")]
public partial class ProcedureCodeMh
{
    [Key]
    public long ProcedureCodeSer { get; set; }

    [Key]
    public int ProcedureCodeRevCount { get; set; }

    public long? ModifierSer { get; set; }

    public int? ActivityCodeMdRevCount { get; set; }

    public long ActivityCategorySer { get; set; }

    [StringLength(64)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(32)]
    public string CodeType { get; set; } = null!;

    [StringLength(64)]
    public string? BillingCode { get; set; }

    public long? DerivedFromProcedureCodeSer { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(64)]
    public string? UserDefinedCode { get; set; }

    [Column(TypeName = "money")]
    public decimal PrmrProfessCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal PrmrTechCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal PrmrGlblCharge { get; set; }

    [Column("ProfessionalRVU")]
    public double? ProfessionalRvu { get; set; }

    [Column("TechnicalRVU")]
    public double? TechnicalRvu { get; set; }

    [Column("GlobalRVU")]
    public double? GlobalRvu { get; set; }

    [Column(TypeName = "money")]
    public decimal OthrProfessCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal OthrTechCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal OthrGlblCharge { get; set; }

    public int ComplexityCode { get; set; }

    [Column(TypeName = "money")]
    public decimal ActivityCost { get; set; }

    [StringLength(254)]
    public string Comment { get; set; } = null!;

    [StringLength(64)]
    public string ShortComment { get; set; } = null!;

    public double? WorkUnit { get; set; }

    [Column(TypeName = "money")]
    public decimal? ChargeForecast { get; set; }

    [Column(TypeName = "money")]
    public decimal? ActualCharge { get; set; }

    public int ExportableFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(64)]
    public string? ExtProcedureCode { get; set; }

    [ForeignKey("ProcedureCodeSer")]
    [InverseProperty("ProcedureCodeMh")]
    public virtual ProcedureCode ProcedureCodeSerNavigation { get; set; } = null!;
}
