using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetPatientWaitTimeData
{
    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndTime { get; set; }

    [Column("Scheduled start time", TypeName = "datetime")]
    public DateTime? ScheduledStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityEndDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientArrivalDateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CheckInTime { get; set; }

    [StringLength(64)]
    public string? ResourceName { get; set; }

    public int MachineDelay { get; set; }

    public int ExpectedWaitTime { get; set; }

    public int? WaitTime { get; set; }

    public int? PatientArrivalDelay { get; set; }

    [StringLength(64)]
    public string? AppointmentStatus { get; set; }

    [Column("AppointmentStatusENU")]
    [StringLength(64)]
    public string? AppointmentStatusEnu { get; set; }

    [StringLength(64)]
    public string ActivityName { get; set; } = null!;

    [StringLength(64)]
    public string? ActivityCategory { get; set; }

    [StringLength(64)]
    public string? ActivityPriority { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(64)]
    public string? PatientFirstName { get; set; }

    [StringLength(64)]
    public string PatientLastName { get; set; } = null!;

    [StringLength(130)]
    public string? PatientFullName { get; set; }

    [StringLength(8)]
    public string? AliasPatientFirstName { get; set; }

    [StringLength(64)]
    public string? HospitalName { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(64)]
    public string? ResourceType { get; set; }

    [Column("Expected Time")]
    [StringLength(15)]
    public string? ExpectedTime { get; set; }

    [Column("Actual Start Time")]
    [StringLength(15)]
    public string? ActualStartTime { get; set; }
}
