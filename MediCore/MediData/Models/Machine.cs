using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("MachineId", Name = "XAKMachine", IsUnique = true)]
[Index("WorkstationSer", Name = "XIF371Machine")]
public partial class Machine
{
    [Key]
    public long ResourceSer { get; set; }

    public long? WorkstationSer { get; set; }

    [StringLength(16)]
    public string MachineId { get; set; } = null!;

    [StringLength(64)]
    public string? MachineName { get; set; }

    [StringLength(30)]
    public string MachineType { get; set; } = null!;

    [StringLength(64)]
    public string MachineModel { get; set; } = null!;

    [StringLength(64)]
    public string? MachineInterface { get; set; }

    [StringLength(16)]
    public string? MachineScale { get; set; }

    [StringLength(254)]
    public string ManufacturerName { get; set; } = null!;

    [StringLength(64)]
    public string? MachineSerialNo { get; set; }

    [StringLength(128)]
    public string? ServiceContact { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateInstalled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastService { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateNextService { get; set; }

    [StringLength(32)]
    public string? OperationStatus { get; set; }

    [StringLength(32)]
    public string? SoftwareVersion { get; set; }

    [StringLength(32)]
    public string? HardwareVersion { get; set; }

    [StringLength(64)]
    public string? Description { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }

    public long? PredecessorSer { get; set; }

    [InverseProperty("ChildResourceSerNavigation")]
    public virtual ICollection<ChildMachine> ChildMachineChildResourceSerNavigation { get; set; } = new List<ChildMachine>();

    [InverseProperty("ParentResourceSerNavigation")]
    public virtual ICollection<ChildMachine> ChildMachineParentResourceSerNavigation { get; set; } = new List<ChildMachine>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<DeliverySetupDeviceMachine> DeliverySetupDeviceMachine { get; set; } = new List<DeliverySetupDeviceMachine>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ImagingDevice? ImagingDevice { get; set; }

    [InverseProperty("PredecessorSerNavigation")]
    public virtual ICollection<Machine> InversePredecessorSerNavigation { get; set; } = new List<Machine>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual MillingMachine? MillingMachine { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<OperatingLimit> OperatingLimit { get; set; } = new List<OperatingLimit>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual PatientSupportDevice? PatientSupportDevice { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual PlanningSystem? PlanningSystem { get; set; }

    [ForeignKey("PredecessorSer")]
    [InverseProperty("InversePredecessorSerNavigation")]
    public virtual Machine? PredecessorSerNavigation { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual RadiationDevice? RadiationDevice { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Machine")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Series> Series { get; set; } = new List<Series>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Slice> Slice { get; set; } = new List<Slice>();

    [ForeignKey("WorkstationSer")]
    [InverseProperty("Machine")]
    public virtual Workstation? WorkstationSerNavigation { get; set; }
}
