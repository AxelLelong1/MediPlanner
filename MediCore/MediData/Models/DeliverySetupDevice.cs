using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class DeliverySetupDevice
{
    [Key]
    public long DeliverySetupDeviceSer { get; set; }

    [StringLength(16)]
    public string DeliverySetupDeviceId { get; set; } = null!;

    [StringLength(64)]
    public string? DeliverySetupDeviceName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    /// <summary>
    /// The type of Setup Device as denoted in DICOM tag (300A,01B6) or for Fixation Device in DICOM tag (300A,0192).
    /// </summary>
    [StringLength(64)]
    public string DeviceType { get; set; } = null!;

    [StringLength(32)]
    public string? DeviceCode { get; set; }

    [StringLength(16)]
    public string DeviceCategory { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    /// <summary>
    /// Manufacturer&apos;s Model Name of the device (0008,1090)
    /// </summary>
    [StringLength(64)]
    public string? ModelName { get; set; }

    /// <summary>
    /// Manufacturer of the device (0008,0070)
    /// </summary>
    [StringLength(64)]
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Name of the xml-file in case for a fixation device defining technique dependent collision 
    /// free envelopes and models used for collision detection in VDR. Fixation device only references this data, it does not own it. This is 
    /// the base part of the file name not including folders.
    /// </summary>
    [StringLength(64)]
    public string? ModelConfigurationReference { get; set; }

    [InverseProperty("DeliverySetupDeviceSerNavigation")]
    public virtual ICollection<DeliverySetupDeviceMachine> DeliverySetupDeviceMachine { get; set; } = new List<DeliverySetupDeviceMachine>();

    [InverseProperty("DeliverySetupDeviceSerNavigation")]
    public virtual ICollection<RadiationDeliverySetupDevice> RadiationDeliverySetupDevice { get; set; } = new List<RadiationDeliverySetupDevice>();
}
