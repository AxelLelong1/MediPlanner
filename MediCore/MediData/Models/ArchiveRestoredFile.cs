using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", "FileName", Name = "XAKArchiveRestoredFile", IsUnique = true)]
public partial class ArchiveRestoredFile
{
    [Key]
    public long ArchiveRestoredFileSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(64)]
    public string FileName { get; set; } = null!;

    [StringLength(64)]
    public string? OriginalFileName { get; set; }

    [StringLength(64)]
    public string DocumentType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ArchiveDate { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("ArchiveRestoredFile")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
