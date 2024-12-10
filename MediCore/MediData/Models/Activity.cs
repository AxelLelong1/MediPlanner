using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityCategorySer", "ActivityCode", Name = "XIE1Activity")]
[Index("ResourceGroupSer", Name = "XIF617Activity")]
[Index("DicomcodeValueSer", Name = "XIF971Activity")]
[Index("TreatmentCycleSer", Name = "XIF972Activity")]
[Index("EscalationGroupSer", Name = "XIF973Activity")]
[Index("UpdCpresourceGroupSer", Name = "XIF974Activity")]
[Index("UpdCpescalationGroupSer", Name = "XIF975Activity")]
public partial class Activity
{
    [Key]
    public long ActivitySer { get; set; }

    public int ActivityRevCount { get; set; }

    public long ActivityCategorySer { get; set; }

    [StringLength(64)]
    public string ActivityCode { get; set; } = null!;

    [StringLength(32)]
    public string ActivityType { get; set; } = null!;

    public long? DerivedFromActivitySer { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public long? ResourceGroupSer { get; set; }

    public int? DefaultDuration { get; set; }

    public int ExclusiveFlag { get; set; }

    public int? NotificationPriorTime { get; set; }

    public int AssignableFlag { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    [MaxLength(4)]
    public byte[]? ForeGroundColor { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Icon { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("DICOMCodeValueSer")]
    public long? DicomcodeValueSer { get; set; }

    public int NotificationPriorTimeFlag { get; set; }

    public long? EscalationGroupSer { get; set; }

    public long? TreatmentCycleSer { get; set; }

    public int ReviewFlag { get; set; }

    [Column("UpdCPResourceGroupSer")]
    public long? UpdCpresourceGroupSer { get; set; }

    [Column("UpdCPEscalationGroupSer")]
    public long? UpdCpescalationGroupSer { get; set; }

    public int AutoGenerateFlag { get; set; }

    public int NoAutoPostFlag { get; set; }

    [InverseProperty("NonSchedulableActivitySerNavigation")]
    public virtual ICollection<ActivityAssociation> ActivityAssociationNonSchedulableActivitySerNavigation { get; set; } = new List<ActivityAssociation>();

    [InverseProperty("SchedulableActivitySerNavigation")]
    public virtual ICollection<ActivityAssociation> ActivityAssociationSchedulableActivitySerNavigation { get; set; } = new List<ActivityAssociation>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityAttribute> ActivityAttribute { get; set; } = new List<ActivityAttribute>();

    [ForeignKey("ActivityCategorySer")]
    [InverseProperty("Activity")]
    public virtual ActivityCategory ActivityCategorySerNavigation { get; set; } = null!;

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityChecklistItem> ActivityChecklistItem { get; set; } = new List<ActivityChecklistItem>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstance { get; set; } = new List<ActivityInstance>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityMh> ActivityMh { get; set; } = new List<ActivityMh>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityPttrn> ActivityPttrn { get; set; } = new List<ActivityPttrn>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityToProcedureCode> ActivityToProcedureCode { get; set; } = new List<ActivityToProcedureCode>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<ActivityToProcedureItem> ActivityToProcedureItem { get; set; } = new List<ActivityToProcedureItem>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<AvailPrefPttrnDetails> AvailPrefPttrnDetails { get; set; } = new List<AvailPrefPttrnDetails>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<AvailPrefWeeklyPttrn> AvailPrefWeeklyPttrn { get; set; } = new List<AvailPrefWeeklyPttrn>();

    [InverseProperty("ActivitySerialNumberNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("ActivitySerialNumberNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("Activity")]
    public virtual DicomcodeValue? DicomcodeValueSerNavigation { get; set; }

    [ForeignKey("EscalationGroupSer")]
    [InverseProperty("ActivityEscalationGroupSerNavigation")]
    public virtual ResourceGroup? EscalationGroupSerNavigation { get; set; }

    [InverseProperty("CtrActivitySerNavigation")]
    public virtual ICollection<InSightiveSimplifiedActivitiesConfigurationTb> InSightiveSimplifiedActivitiesConfigurationTb { get; set; } = new List<InSightiveSimplifiedActivitiesConfigurationTb>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<PatientListQueryConfiguration> PatientListQueryConfiguration { get; set; } = new List<PatientListQueryConfiguration>();

    [InverseProperty("ActivitySerNavigation")]
    public virtual ICollection<PttrnRelatedNonSchActivity> PttrnRelatedNonSchActivity { get; set; } = new List<PttrnRelatedNonSchActivity>();

    [ForeignKey("ResourceGroupSer")]
    [InverseProperty("ActivityResourceGroupSerNavigation")]
    public virtual ResourceGroup? ResourceGroupSerNavigation { get; set; }

    [ForeignKey("TreatmentCycleSer")]
    [InverseProperty("Activity")]
    public virtual TreatmentCycle? TreatmentCycleSerNavigation { get; set; }

    [ForeignKey("UpdCpescalationGroupSer")]
    [InverseProperty("ActivityUpdCpescalationGroupSerNavigation")]
    public virtual ResourceGroup? UpdCpescalationGroupSerNavigation { get; set; }

    [ForeignKey("UpdCpresourceGroupSer")]
    [InverseProperty("ActivityUpdCpresourceGroupSerNavigation")]
    public virtual ResourceGroup? UpdCpresourceGroupSerNavigation { get; set; }
}
