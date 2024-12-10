using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Address
{
    [Key]
    public long AddressSer { get; set; }

    [StringLength(64)]
    public string AddressType { get; set; } = null!;

    [StringLength(64)]
    public string? Country { get; set; }

    [StringLength(64)]
    public string? StateOrProvince { get; set; }

    [StringLength(64)]
    public string? Location { get; set; }

    [StringLength(64)]
    public string? County { get; set; }

    [StringLength(64)]
    public string? CityOrTownship { get; set; }

    [StringLength(64)]
    public string? AddressLine1 { get; set; }

    [StringLength(64)]
    public string? AddressLine2 { get; set; }

    [StringLength(64)]
    public string? AddressLine3 { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OriginationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TerminationDate { get; set; }

    [StringLength(64)]
    public string? PhoneNumber1 { get; set; }

    [StringLength(64)]
    public string? PhoneNumber2 { get; set; }

    [StringLength(64)]
    public string? FaxNumber { get; set; }

    [Column("EMailAddress")]
    [StringLength(64)]
    public string? EmailAddress { get; set; }

    [StringLength(64)]
    public string? PagerNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("AddressSerNavigation")]
    public virtual ICollection<Employer> Employer { get; set; } = new List<Employer>();

    [InverseProperty("AddressSerNavigation")]
    public virtual ICollection<Hospital> Hospital { get; set; } = new List<Hospital>();

    [InverseProperty("AddressSerNavigation")]
    public virtual ICollection<PatientAddress> PatientAddress { get; set; } = new List<PatientAddress>();

    [InverseProperty("AddressSerNavigation")]
    public virtual ICollection<PointOfContact> PointOfContact { get; set; } = new List<PointOfContact>();

    [InverseProperty("AddressSerNavigation")]
    public virtual ICollection<ResourceAddress> ResourceAddress { get; set; } = new List<ResourceAddress>();
}
