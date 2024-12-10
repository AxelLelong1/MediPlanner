using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", "AddOnId", Name = "XAKAddOn", IsUnique = true)]
[Index("AddOnMaterialSer", Name = "XIF369AddOn")]
public partial class AddOn
{
    [Key]
    public long AddOnSer { get; set; }

    public long ResourceSer { get; set; }

    public long? AddOnMaterialSer { get; set; }

    [StringLength(16)]
    public string AddOnId { get; set; } = null!;

    [StringLength(64)]
    public string? AddOnName { get; set; }

    [StringLength(30)]
    public string? AddOnType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(32)]
    public string? DisplayCode { get; set; }

    public int? InternalCode { get; set; }

    public int ExtDeviceVerification { get; set; }

    public int OverridePossible { get; set; }

    public int ValidationDone { get; set; }

    [Column("PFVerifyDone")]
    public int PfverifyDone { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddOnMaterialSer")]
    [InverseProperty("AddOn")]
    public virtual AddOnMaterial? AddOnMaterialSerNavigation { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual ICollection<AddOnValidation> AddOnValidation { get; set; } = new List<AddOnValidation>();

    [InverseProperty("AddOnSerNavigation")]
    public virtual Applicator? Applicator { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual BeamlineOption? BeamlineOption { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual ICollection<ControlPointProton> ControlPointProton { get; set; } = new List<ControlPointProton>();

    [InverseProperty("AddOnSerNavigation")]
    public virtual ICollection<FieldAddOn> FieldAddOn { get; set; } = new List<FieldAddOn>();

    [InverseProperty("AddOnSerNavigation")]
    public virtual Mlc? Mlc { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual PrimaryFluenceMode? PrimaryFluenceMode { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual ProtonBeamSpot? ProtonBeamSpot { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual ProtonLateralSpreader? ProtonLateralSpreader { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual RangeModulator? RangeModulator { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual RangeShifter? RangeShifter { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("AddOn")]
    public virtual ExternalBeam ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("AddOnSerNavigation")]
    public virtual ICollection<SlotAddOn> SlotAddOn { get; set; } = new List<SlotAddOn>();

    [InverseProperty("AddOnSerNavigation")]
    public virtual Snout? Snout { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual Tray? Tray { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual Wedge? Wedge { get; set; }
}
