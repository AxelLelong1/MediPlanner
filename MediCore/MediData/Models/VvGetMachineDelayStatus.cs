using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetMachineDelayStatus
{
    public long? RowNumber { get; set; }

    public long? RowOrderInParticularMachine { get; set; }

    [StringLength(64)]
    public string ActivityCategoryCode { get; set; } = null!;

    [StringLength(64)]
    public string ActivityCode { get; set; } = null!;

    [StringLength(32)]
    public string ActivityType { get; set; } = null!;

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsScheduled { get; set; } = null!;

    [StringLength(64)]
    public string? Priority { get; set; }

    [StringLength(64)]
    public string? ScheduledActivityCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualEndDate { get; set; }

    [StringLength(16)]
    public string ScheduledActivityObjectStatus { get; set; } = null!;

    [StringLength(16)]
    public string ActivityObjectStatus { get; set; } = null!;

    [StringLength(16)]
    public string MachineId { get; set; } = null!;

    [StringLength(64)]
    public string MachineName { get; set; } = null!;

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

    [Column(TypeName = "datetime")]
    public DateTime? DateInstalled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastService { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateNextService { get; set; }

    [StringLength(32)]
    public string? OperationStatus { get; set; }

    [StringLength(64)]
    public string? MachineDescription { get; set; }

    public int? MachineCapacity { get; set; }

    public int? MachineUse { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [StringLength(30)]
    public string? PatientType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(16)]
    public string? Honorific { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    [StringLength(64)]
    public string? BirthCity { get; set; }

    [StringLength(64)]
    public string? BirthState { get; set; }

    [StringLength(64)]
    public string? BirthCountry { get; set; }
}
