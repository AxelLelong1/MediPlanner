using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("BillingServiceId", Name = "XAK1BillingService", IsUnique = true)]
public partial class BillingService
{
    [Key]
    public long BillingServiceSer { get; set; }

    [Column("BillingServiceID")]
    [StringLength(16)]
    public string BillingServiceId { get; set; } = null!;

    [StringLength(64)]
    public string BillingServiceName { get; set; } = null!;

    [StringLength(64)]
    public string? Location { get; set; }

    [StringLength(64)]
    public string? AddressLine1 { get; set; }

    [StringLength(64)]
    public string? AddressLine2 { get; set; }

    [StringLength(64)]
    public string? AddressLine3 { get; set; }

    [StringLength(64)]
    public string? CityorTownship { get; set; }

    [StringLength(64)]
    public string? County { get; set; }

    [StringLength(64)]
    public string? StateOrProvince { get; set; }

    [StringLength(64)]
    public string? Country { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [Column("POCName")]
    [StringLength(254)]
    public string? Pocname { get; set; }

    [Column("POCPhoneNumber")]
    [StringLength(64)]
    public string? PocphoneNumber { get; set; }

    [Column("POCFaxNumber")]
    [StringLength(64)]
    public string? PocfaxNumber { get; set; }

    public int ExtBillingExportFlag { get; set; }

    [Column("RVUExportFlag")]
    public int RvuexportFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("BillingServiceSerNavigation")]
    public virtual ICollection<DoctorBillingService> DoctorBillingService { get; set; } = new List<DoctorBillingService>();
}
