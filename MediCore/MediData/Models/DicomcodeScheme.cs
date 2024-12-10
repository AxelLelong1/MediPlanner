using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DICOMCodeScheme")]
[Index("Designator", "Version", Name = "XAK1DICOMCodeScheme", IsUnique = true)]
public partial class DicomcodeScheme
{
    [Key]
    [Column("DICOMCodeSchemeSer")]
    public long DicomcodeSchemeSer { get; set; }

    [StringLength(16)]
    public string Designator { get; set; } = null!;

    [StringLength(16)]
    public string? Version { get; set; }

    [StringLength(64)]
    public string? Registry { get; set; }

    [Column("UID")]
    [StringLength(64)]
    public string? Uid { get; set; }

    [Column("ExternalID")]
    public string? ExternalId { get; set; }

    public string? CommonName { get; set; }

    public string? ResponsibleOrganization { get; set; }

    [InverseProperty("DicomcodeSchemeSerNavigation")]
    public virtual ICollection<DicomcodeValue> DicomcodeValue { get; set; } = new List<DicomcodeValue>();
}
