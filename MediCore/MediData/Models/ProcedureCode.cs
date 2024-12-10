using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityCategorySer", "ProcedureCode1", "BillingCode", Name = "XIE1ProcedureCode")]
[Index("DepartmentSer", Name = "XIF1007ProcedureCode")]
[Index("ModifierSer", Name = "XIF658ProcedureCode")]
public partial class ProcedureCode
{
    [Key]
    public long ProcedureCodeSer { get; set; }

    public int ProcedureCodeRevCount { get; set; }

    public long? ModifierSer { get; set; }

    public int? ActivityCodeMdRevCount { get; set; }

    public long ActivityCategorySer { get; set; }

    [Column("ProcedureCode")]
    [StringLength(64)]
    public string ProcedureCode1 { get; set; } = null!;

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

    [InverseProperty("ProcedureCodeSerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCode { get; set; } = new List<ActInstProcCode>();

    [ForeignKey("ActivityCategorySer")]
    [InverseProperty("ProcedureCode")]
    public virtual ActivityCategory ActivityCategorySerNavigation { get; set; } = null!;

    [InverseProperty("ProcedureCodeSerNavigation")]
    public virtual ICollection<ActivityToProcedureCode> ActivityToProcedureCode { get; set; } = new List<ActivityToProcedureCode>();

    [InverseProperty("ProcedureCodeSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("ProcedureCodeSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ProcedureCode")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("ModifierSer")]
    [InverseProperty("ProcedureCode")]
    public virtual ActivityCodeMd? ModifierSerNavigation { get; set; }

    [InverseProperty("ProcedureCodeSerNavigation")]
    public virtual ICollection<ProcedureCodeMh> ProcedureCodeMh { get; set; } = new List<ProcedureCodeMh>();
}
