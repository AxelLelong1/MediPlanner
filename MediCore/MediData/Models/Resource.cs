using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceTypeNum", Name = "XIF349Resource")]
[Index("DicomcodeValueSer", Name = "XIF969Resource")]
public partial class Resource
{
    [Key]
    public long ResourceSer { get; set; }

    public int ResourceTypeNum { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(30)]
    public string ResourceType { get; set; } = null!;

    public int SchedulableFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("DICOMCodeValueSer")]
    public long? DicomcodeValueSer { get; set; }

    [StringLength(64)]
    public string? WorklistType { get; set; }

    [Column("AETitle")]
    [StringLength(16)]
    public string? Aetitle { get; set; }

    public int MultiProtocolFlag { get; set; }

    [StringLength(256)]
    public string? DirectAddress { get; set; }

    [InverseProperty("AttendingOncologistSerNavigation")]
    public virtual ICollection<ActivityCapture> ActivityCapture { get; set; } = new List<ActivityCapture>();

    [InverseProperty("LastNoteUpdatedByResourceSerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstanceLastNoteUpdatedByResourceSerNavigation { get; set; } = new List<ActivityInstance>();

    [InverseProperty("LastStatusUpdatedByResourceSerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstanceLastStatusUpdatedByResourceSerNavigation { get; set; } = new List<ActivityInstance>();

    [InverseProperty("WorkFlowOverrideByResourceSerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstanceWorkFlowOverrideByResourceSerNavigation { get; set; } = new List<ActivityInstance>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ActivityPttrnResrc> ActivityPttrnResrc { get; set; } = new List<ActivityPttrnResrc>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<AppUser> AppUser { get; set; } = new List<AppUser>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Attendee> Attendee { get; set; } = new List<Attendee>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual Auxiliary? Auxiliary { get; set; }

    [InverseProperty("MillingMachineResourceSerNavigation")]
    public virtual ICollection<Block> Block { get; set; } = new List<Block>();

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("Resource")]
    public virtual DicomcodeValue? DicomcodeValueSerNavigation { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual Doctor? Doctor { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<GroupResource> GroupResource { get; set; } = new List<GroupResource>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual Machine? Machine { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Message1> Message1 { get; set; } = new List<Message1>();

    [InverseProperty("CreatedByResourceSerNavigation")]
    public virtual ICollection<NonScheduledActivity> NonScheduledActivity { get; set; } = new List<NonScheduledActivity>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ProcedureItemResource> ProcedureItemResource { get; set; } = new List<ProcedureItemResource>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Recipient> Recipient { get; set; } = new List<Recipient>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ResourceAddress> ResourceAddress { get; set; } = new List<ResourceAddress>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ResourceDepartment> ResourceDepartment { get; set; } = new List<ResourceDepartment>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ResourceEmergencyGroup? ResourceEmergencyGroup { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ResourceIdentifier> ResourceIdentifier { get; set; } = new List<ResourceIdentifier>();

    [ForeignKey("ResourceTypeNum")]
    [InverseProperty("Resource")]
    public virtual ResourceType ResourceTypeNumNavigation { get; set; } = null!;

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ResourceVenue> ResourceVenue { get; set; } = new List<ResourceVenue>();

    [InverseProperty("CreatedByResourceSerNavigation")]
    public virtual ICollection<ScheduledActivity> ScheduledActivity { get; set; } = new List<ScheduledActivity>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual Staff? Staff { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Template> Template { get; set; } = new List<Template>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual Venue? Venue { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual Workspace? Workspace { get; set; }
}
