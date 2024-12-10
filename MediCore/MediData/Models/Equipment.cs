using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Equipment
{
    [Key]
    public long EquipmentSer { get; set; }

    [StringLength(64)]
    public string? Manufacturer { get; set; }

    [StringLength(64)]
    public string? InstitutionName { get; set; }

    [StringLength(16)]
    public string? StationName { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(64)]
    public string? ModelName { get; set; }

    [StringLength(64)]
    public string? DeviceSerialNumber { get; set; }

    [StringLength(64)]
    public string? SoftwareVersion { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(1024)]
    public string? InstitutionAddress { get; set; }

    [InverseProperty("EquipmentSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("EquipmentSerNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [InverseProperty("ContributingEquipmentSerNavigation")]
    public virtual ICollection<Slice> SliceContributingEquipmentSerNavigation { get; set; } = new List<Slice>();

    [InverseProperty("EquipmentSerNavigation")]
    public virtual ICollection<Slice> SliceEquipmentSerNavigation { get; set; } = new List<Slice>();

    [InverseProperty("EquipmentSerNavigation")]
    public virtual ICollection<SpatialRegistrationIod> SpatialRegistrationIod { get; set; } = new List<SpatialRegistrationIod>();

    [InverseProperty("EquipmentSerNavigation")]
    public virtual ICollection<StructureSet> StructureSet { get; set; } = new List<StructureSet>();

    [InverseProperty("EquipmentSerNavigation")]
    public virtual ICollection<Tracking> Tracking { get; set; } = new List<Tracking>();
}
