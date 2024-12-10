using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class GetActivityTransaction14days
{
    public long ScheduledActivitySer { get; set; }

    public long ActivityInstanceSer { get; set; }

    public long? PatientSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDateTime { get; set; }

    [StringLength(64)]
    public string? AppointmentStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityEndDateTime { get; set; }

    [StringLength(255)]
    public string? ActivityCreatedBy { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsScheduled { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndTime { get; set; }

    [StringLength(64)]
    public string? PrimaryOncologistLastName { get; set; }

    [StringLength(64)]
    public string? PrimaryOncologistAliasName { get; set; }

    [StringLength(64)]
    public string? ResourceTypeCode { get; set; }

    [StringLength(64)]
    public string ActivityName { get; set; } = null!;

    [StringLength(64)]
    public string ActivityCategory { get; set; } = null!;

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [StringLength(64)]
    public string? PatientFirstName { get; set; }

    [StringLength(64)]
    public string? PatientLastName { get; set; }

    [StringLength(130)]
    public string PatientFullName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PatientArrivalDateTime { get; set; }

    [StringLength(64)]
    public string HospitalName { get; set; } = null!;

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(64)]
    public string? OwnerFirstName { get; set; }

    [StringLength(64)]
    public string? OwnerLastName { get; set; }

    [StringLength(30)]
    public string? ResourceType { get; set; }

    public long? AttendeeResourceSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }
}
