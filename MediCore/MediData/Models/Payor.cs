using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanNumber", "CompanyName", Name = "XAK1Payor", IsUnique = true)]
[Index("PlanTypeSer", Name = "XIF401Payor")]
public partial class Payor
{
    [Key]
    public long PayorSer { get; set; }

    public long? PlanTypeSer { get; set; }

    [StringLength(16)]
    public string PlanNumber { get; set; } = null!;

    [StringLength(64)]
    public string CompanyName { get; set; } = null!;

    [StringLength(64)]
    public string? StreetAddress1 { get; set; }

    [StringLength(64)]
    public string? StreetAddress2 { get; set; }

    [StringLength(64)]
    public string? City { get; set; }

    [StringLength(64)]
    public string? State { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [StringLength(64)]
    public string? Country { get; set; }

    [StringLength(64)]
    public string? PrimaryContactName { get; set; }

    [StringLength(64)]
    public string? Phone { get; set; }

    [Column("FAX")]
    [StringLength(64)]
    public string? Fax { get; set; }

    [StringLength(64)]
    public string? EmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int? NumOfPlanMmbrs { get; set; }

    [Column(TypeName = "money")]
    public decimal? MnthlyPaymntPerMmbr { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalPaymntPerDiag { get; set; }

    [Column(TypeName = "money")]
    public decimal? PlanDeductible { get; set; }

    [Column(TypeName = "money")]
    public decimal? PlanLimitAmount { get; set; }

    public int? PlanLimitDays { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PayorSerNavigation")]
    public virtual ICollection<ActivityCapture> ActivityCapture { get; set; } = new List<ActivityCapture>();

    [InverseProperty("PayorSerNavigation")]
    public virtual ICollection<PatientPayor> PatientPayor { get; set; } = new List<PatientPayor>();

    [InverseProperty("PayorSerNavigation")]
    public virtual ICollection<PayorAuthorization> PayorAuthorization { get; set; } = new List<PayorAuthorization>();

    [ForeignKey("PlanTypeSer")]
    [InverseProperty("Payor")]
    public virtual PlanTypes? PlanTypeSerNavigation { get; set; }

    [InverseProperty("PayorSerNavigation")]
    public virtual ICollection<Template> Template { get; set; } = new List<Template>();
}
