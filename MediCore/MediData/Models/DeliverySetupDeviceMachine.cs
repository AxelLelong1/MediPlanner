using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DeliverySetupDeviceSer", "ResourceSer")]
[Index("CacheKeySer", Name = "XAK1DeliverySetupDeviceMachine", IsUnique = true)]
[Index("ResourceSer", Name = "XIF915DeliverySetupDeviceMachi")]
public partial class DeliverySetupDeviceMachine
{
    [Key]
    public long DeliverySetupDeviceSer { get; set; }

    [Key]
    public long ResourceSer { get; set; }

    public long CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DeliverySetupDeviceSer")]
    [InverseProperty("DeliverySetupDeviceMachine")]
    public virtual DeliverySetupDevice DeliverySetupDeviceSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("DeliverySetupDeviceMachine")]
    public virtual Machine ResourceSerNavigation { get; set; } = null!;
}
