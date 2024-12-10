using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DicomcodeValueSer", Name = "XIF1StructureCode")]
[Index("PurposeDicomcodeValueSer", Name = "XIF2StructureCode")]
public partial class StructureCode
{
    [Key]
    public long StructureCodeSer { get; set; }

    [Column("DICOMCodeValueSer")]
    public long DicomcodeValueSer { get; set; }

    [Column("PurposeDICOMCodeValueSer")]
    public long? PurposeDicomcodeValueSer { get; set; }

    [StringLength(16)]
    public string? DefaultStructureId { get; set; }

    [StringLength(254)]
    public string? Synonyms { get; set; }

    public int ActiveSubsetFlag { get; set; }

    public int ProtectedSubsetFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("TargetStructureCodeSerNavigation")]
    public virtual ICollection<CodeStructureCode> CodeStructureCode { get; set; } = new List<CodeStructureCode>();

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("StructureCodeDicomcodeValueSerNavigation")]
    public virtual DicomcodeValue DicomcodeValueSerNavigation { get; set; } = null!;

    [ForeignKey("PurposeDicomcodeValueSer")]
    [InverseProperty("StructureCodePurposeDicomcodeValueSerNavigation")]
    public virtual DicomcodeValue? PurposeDicomcodeValueSerNavigation { get; set; }

    [InverseProperty("TargetStructureCodeSerNavigation")]
    public virtual ICollection<StructureIdStructureCode> StructureIdStructureCode { get; set; } = new List<StructureIdStructureCode>();

    [InverseProperty("StructureCodeSerNavigation")]
    public virtual ICollection<StructureStructureCode> StructureStructureCode { get; set; } = new List<StructureStructureCode>();
}
