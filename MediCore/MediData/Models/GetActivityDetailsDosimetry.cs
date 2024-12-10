using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class GetActivityDetailsDosimetry
{
    public long ScheduledActivitySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledStartTime { get; set; }

    [StringLength(64)]
    public string? AppointmentStatus { get; set; }

    public int AppointmentStatusNumber { get; set; }

    [Column("Current Status")]
    [StringLength(64)]
    public string? CurrentStatus { get; set; }

    [StringLength(64)]
    public string? DerivedActivityStatus { get; set; }

    [StringLength(64)]
    public string? ActivityName { get; set; }

    [StringLength(64)]
    public string? ActivityCategory { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsScheduled { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ActivityStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityEndDate { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(64)]
    public string? PatientFirstName { get; set; }

    [StringLength(64)]
    public string? PatientLastName { get; set; }

    [StringLength(130)]
    public string PatientFullName { get; set; } = null!;

    [StringLength(64)]
    public string OncologistName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PatientArrivalDateTime { get; set; }

    [StringLength(64)]
    public string HospitalName { get; set; } = null!;

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(40)]
    public string DxSite { get; set; } = null!;

    [StringLength(64)]
    public string? ResourceName { get; set; }

    public int IsOverdue { get; set; }

    [StringLength(64)]
    public string? OwnerFirstName { get; set; }

    [StringLength(64)]
    public string? OwnerLastName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DerivedAppointmentDateTime { get; set; }

    [Column("ARank")]
    public long? Arank { get; set; }

    public int? Duration { get; set; }
}
