using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillingServiceSer", "ResourceSer")]
[Index("ResourceSer", Name = "XIF497DoctorBillingService")]
public partial class DoctorBillingService
{
    [Key]
    public long BillingServiceSer { get; set; }

    [Key]
    public long ResourceSer { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("BillingServiceSer")]
    [InverseProperty("DoctorBillingService")]
    public virtual BillingService BillingServiceSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("DoctorBillingService")]
    public virtual Doctor ResourceSerNavigation { get; set; } = null!;
}
