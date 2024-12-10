using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DICOMCodeValue")]
[Index("DicomcodeSchemeSer", "Value", Name = "XAK1DICOMCodeValue", IsUnique = true)]
public partial class DicomcodeValue
{
    [Key]
    [Column("DICOMCodeValueSer")]
    public long DicomcodeValueSer { get; set; }

    [Column("DICOMCodeSchemeSer")]
    public long DicomcodeSchemeSer { get; set; }

    [StringLength(16)]
    public string Value { get; set; } = null!;

    [StringLength(64)]
    public string? Category { get; set; }

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<Activity> Activity { get; set; } = new List<Activity>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<DerivedImageCode> DerivedImageCode { get; set; } = new List<DerivedImageCode>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<DicomcodeMeaning> DicomcodeMeaning { get; set; } = new List<DicomcodeMeaning>();

    [ForeignKey("DicomcodeSchemeSer")]
    [InverseProperty("DicomcodeValue")]
    public virtual DicomcodeScheme DicomcodeSchemeSerNavigation { get; set; } = null!;

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<ImageRelatedInstance> ImageRelatedInstance { get; set; } = new List<ImageRelatedInstance>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<PerformedProcedure> PerformedProcedure { get; set; } = new List<PerformedProcedure>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<ProcedureItem> ProcedureItem { get; set; } = new List<ProcedureItem>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<Resource> Resource { get; set; } = new List<Resource>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<ResourceGroup> ResourceGroup { get; set; } = new List<ResourceGroup>();

    [InverseProperty("DicomcodeValueSerNavigation")]
    public virtual ICollection<StructureCode> StructureCodeDicomcodeValueSerNavigation { get; set; } = new List<StructureCode>();

    [InverseProperty("PurposeDicomcodeValueSerNavigation")]
    public virtual ICollection<StructureCode> StructureCodePurposeDicomcodeValueSerNavigation { get; set; } = new List<StructureCode>();
}
