using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("InSightive_SimplifiedGroupConfiguration_TB", Schema = "DWH")]
public partial class InSightiveSimplifiedGroupConfigurationTb
{
    [Key]
    [Column("GroupID")]
    public int GroupId { get; set; }

    [StringLength(512)]
    public string? GroupName { get; set; }

    public int? CallOutDays { get; set; }

    public int? AppointmentFromDays { get; set; }

    public int? AppointmentToDays { get; set; }

    public int? DaysToLookForNonCarePathInPast { get; set; }

    public int? DaysToLookForFutureActivities { get; set; }

    public int? SortOrder { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [StringLength(255)]
    public string ModifiedByUserName { get; set; } = null!;

    [InverseProperty("Group")]
    public virtual ICollection<InSightiveSimplifiedActivitiesConfigurationTb> InSightiveSimplifiedActivitiesConfigurationTb { get; set; } = new List<InSightiveSimplifiedActivitiesConfigurationTb>();

    [InverseProperty("Group")]
    public virtual ICollection<InSightiveSimplifiedDxSiteConfigurationTb> InSightiveSimplifiedDxSiteConfigurationTb { get; set; } = new List<InSightiveSimplifiedDxSiteConfigurationTb>();

    [InverseProperty("Group")]
    public virtual ICollection<InSightiveSimplifiedHospDeptConfigurationTb> InSightiveSimplifiedHospDeptConfigurationTb { get; set; } = new List<InSightiveSimplifiedHospDeptConfigurationTb>();

    [InverseProperty("Group")]
    public virtual ICollection<InSightiveSimplifiedPrimaryOncoConfigurationTb> InSightiveSimplifiedPrimaryOncoConfigurationTb { get; set; } = new List<InSightiveSimplifiedPrimaryOncoConfigurationTb>();
}
