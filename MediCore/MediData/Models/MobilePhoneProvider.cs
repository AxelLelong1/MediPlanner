using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class MobilePhoneProvider
{
    [Key]
    public long MobilePhoneProviderSer { get; set; }

    [StringLength(64)]
    public string ProviderName { get; set; } = null!;

    [Column("SMSMsgDomainName")]
    [StringLength(64)]
    public string SmsmsgDomainName { get; set; } = null!;

    public int ActiveFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("MobilePhoneProviderSerNavigation")]
    public virtual ICollection<Patient> Patient { get; set; } = new List<Patient>();
}
