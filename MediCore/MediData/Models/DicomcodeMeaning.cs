using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DICOMCodeMeaning")]
[Index("DicomcodeValueSer", "Meaning", "LanguageId", Name = "XAK1DICOMCodeMeaning", IsUnique = true)]
public partial class DicomcodeMeaning
{
    [Key]
    [Column("DICOMCodeMeaningSer")]
    public long DicomcodeMeaningSer { get; set; }

    [Column("DICOMCodeValueSer")]
    public long DicomcodeValueSer { get; set; }

    [StringLength(64)]
    public string Meaning { get; set; } = null!;

    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [StringLength(64)]
    public string? DisplayName { get; set; }

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("DicomcodeMeaning")]
    public virtual DicomcodeValue DicomcodeValueSerNavigation { get; set; } = null!;
}
