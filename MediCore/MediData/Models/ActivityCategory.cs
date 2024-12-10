using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DepartmentSer", "ActivityCategoryCode", Name = "XAK1EventType", IsUnique = true)]
public partial class ActivityCategory
{
    [Key]
    public long ActivityCategorySer { get; set; }

    [StringLength(64)]
    public string ActivityCategoryCode { get; set; } = null!;

    public long? DepartmentSer { get; set; }

    public long? DerivedFromActCategorySer { get; set; }

    public int? SchedulableFlag { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ActivityCategorySerNavigation")]
    public virtual ICollection<Activity> Activity { get; set; } = new List<Activity>();

    [InverseProperty("ActivityCategorySerNavigation")]
    public virtual ICollection<ActtyCatgryResrcType> ActtyCatgryResrcType { get; set; } = new List<ActtyCatgryResrcType>();

    [InverseProperty("ActivityCategorySerNavigation")]
    public virtual ICollection<AvailPrefPttrnDetails> AvailPrefPttrnDetails { get; set; } = new List<AvailPrefPttrnDetails>();

    [InverseProperty("ActivityCategorySerNavigation")]
    public virtual ICollection<AvailPrefWeeklyPttrn> AvailPrefWeeklyPttrn { get; set; } = new List<AvailPrefWeeklyPttrn>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ActivityCategory")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [InverseProperty("CtrActivityCategorySerNavigation")]
    public virtual ICollection<InSightiveSimplifiedActivitiesConfigurationTb> InSightiveSimplifiedActivitiesConfigurationTb { get; set; } = new List<InSightiveSimplifiedActivitiesConfigurationTb>();

    [InverseProperty("ActivityCategorySerNavigation")]
    public virtual ICollection<ProcedureCode> ProcedureCode { get; set; } = new List<ProcedureCode>();
}
