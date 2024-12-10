using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("RadiationSer", "DeliverySetupDeviceSer")]
[Index("CacheKeySer", Name = "XAK1RadiationDeliverySetupDevi", IsUnique = true)]
[Index("DeliverySetupDeviceSer", Name = "XIF917RadiationDeliverySetupDe")]
public partial class RadiationDeliverySetupDevice
{
    [Key]
    public long RadiationSer { get; set; }

    [Key]
    public long DeliverySetupDeviceSer { get; set; }

    public long CacheKeySer { get; set; }

    [StringLength(64)]
    public string? CustomCode { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DeliverySetupDeviceSer")]
    [InverseProperty("RadiationDeliverySetupDevice")]
    public virtual DeliverySetupDevice DeliverySetupDeviceSerNavigation { get; set; } = null!;

    [ForeignKey("RadiationSer")]
    [InverseProperty("RadiationDeliverySetupDevice")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;
}
