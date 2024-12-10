using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("InSightive_SimplifiedActivitiesConfiguration_TB", Schema = "DWH")]
public partial class InSightiveSimplifiedActivitiesConfigurationTb
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GroupID")]
    public int? GroupId { get; set; }

    [Column("ctrActivitySer")]
    public long CtrActivitySer { get; set; }

    [Column("ctrActivityCategorySer")]
    public long CtrActivityCategorySer { get; set; }

    [Column("ctrStatusLookupTableSer")]
    public long? CtrStatusLookupTableSer { get; set; }

    public int? CallOutDays { get; set; }

    public bool? IsNewStartActivity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [StringLength(255)]
    public string ModifiedByUserName { get; set; } = null!;

    [ForeignKey("CtrActivityCategorySer")]
    [InverseProperty("InSightiveSimplifiedActivitiesConfigurationTb")]
    public virtual ActivityCategory CtrActivityCategorySerNavigation { get; set; } = null!;

    [ForeignKey("CtrActivitySer")]
    [InverseProperty("InSightiveSimplifiedActivitiesConfigurationTb")]
    public virtual Activity CtrActivitySerNavigation { get; set; } = null!;

    [ForeignKey("CtrStatusLookupTableSer")]
    [InverseProperty("InSightiveSimplifiedActivitiesConfigurationTb")]
    public virtual LookupTable? CtrStatusLookupTableSerNavigation { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("InSightiveSimplifiedActivitiesConfigurationTb")]
    public virtual InSightiveSimplifiedGroupConfigurationTb? Group { get; set; }
}
