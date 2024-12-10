using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimActivityTransaction
{
    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDateTime { get; set; }

    [StringLength(64)]
    public string? AppointmentStatus { get; set; }

    [StringLength(64)]
    public string ActivityName { get; set; } = null!;

    [StringLength(64)]
    public string ActivityCategory { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string IsScheduled { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ActivityStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityEndDateTime { get; set; }

    [StringLength(64)]
    public string? ActivityPriority { get; set; }

    [StringLength(254)]
    public string? ActivityNote { get; set; }

    [StringLength(255)]
    public string? ActivityCreatedBy { get; set; }

    [StringLength(255)]
    public string? ActivityCompletedBy { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [StringLength(130)]
    public string? PatientFullName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CheckedIn { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PatientArrivalDateTime { get; set; }

    [StringLength(64)]
    public string? HospitalName { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(64)]
    public string? ResourceName { get; set; }

    [StringLength(64)]
    public string? ResourceType { get; set; }

    public int? ResourceTypeNum { get; set; }

    [StringLength(64)]
    public string? PatientLocation { get; set; }

    public int WaitListedFlag { get; set; }

    public int ActivityRevCount { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [Column("ctrResourceGroupSer")]
    public long CtrResourceGroupSer { get; set; }

    [Column("ctrAttendeeSer")]
    public long CtrAttendeeSer { get; set; }

    [Column("ctrScheduledActivitySer")]
    public long CtrScheduledActivitySer { get; set; }

    [Column("ctrActivityInstanceSer")]
    public long CtrActivityInstanceSer { get; set; }

    [Column("ctrActivitySer")]
    public long CtrActivitySer { get; set; }

    [Column("ctrActivityCategorySer")]
    public long CtrActivityCategorySer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [Column("ctrCreatedByResourceSer")]
    public long? CtrCreatedByResourceSer { get; set; }

    public int? ActivityInstanceRevCount { get; set; }

    [Column("DimDateID_CreationDate")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdCreationDate { get; set; } = null!;

    public int AppointmentInstanceFlag { get; set; }

    [StringLength(16)]
    public string? AppointmentResourceStatus { get; set; }

    public int? ActivityOwnerFlag { get; set; }
}
