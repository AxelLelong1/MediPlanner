using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("SpatialRegistrationIOD")]
[Index("SpatialRegistrationUid", Name = "XAK1SpatialRegistrationIOD", IsUnique = true)]
[Index("SeriesSer", Name = "XIF850SpatialRegistrationIOD")]
[Index("EquipmentSer", Name = "XIF893SpatialRegistrationIOD")]
public partial class SpatialRegistrationIod
{
    [Key]
    [Column("SpatialRegistrationIODSer")]
    public long SpatialRegistrationIodser { get; set; }

    public long SeriesSer { get; set; }

    [Column("SpatialRegistrationIODId")]
    [StringLength(16)]
    public string SpatialRegistrationIodid { get; set; } = null!;

    [Column("SpatialRegistrationUID")]
    [StringLength(64)]
    public string SpatialRegistrationUid { get; set; } = null!;

    public int InstanceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public long? EquipmentSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(32)]
    public string RegistrationType { get; set; } = null!;

    [StringLength(254)]
    public string? FileName { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }

    [ForeignKey("EquipmentSer")]
    [InverseProperty("SpatialRegistrationIod")]
    public virtual Equipment? EquipmentSerNavigation { get; set; }

    [InverseProperty("RegistrationFromReferenceSerNavigation")]
    public virtual ICollection<PlanSumPlanSetup> PlanSumPlanSetupRegistrationFromReferenceSerNavigation { get; set; } = new List<PlanSumPlanSetup>();

    [InverseProperty("RegistrationToReferenceSerNavigation")]
    public virtual ICollection<PlanSumPlanSetup> PlanSumPlanSetupRegistrationToReferenceSerNavigation { get; set; } = new List<PlanSumPlanSetup>();

    [ForeignKey("SeriesSer")]
    [InverseProperty("SpatialRegistrationIod")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("SpatialRegistrationIodserNavigation")]
    public virtual ICollection<SpatialRegistration> SpatialRegistration { get; set; } = new List<SpatialRegistration>();
}
