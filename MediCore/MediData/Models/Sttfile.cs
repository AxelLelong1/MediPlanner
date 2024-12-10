using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("STTFile")]
[Index("AddOnSer", "FileId", Name = "XAKSTTFile", IsUnique = true)]
public partial class Sttfile
{
    [Key]
    [Column("STTFileSer")]
    public long SttfileSer { get; set; }

    public long AddOnSer { get; set; }

    [StringLength(16)]
    public string FileId { get; set; } = null!;

    [StringLength(254)]
    public string? FileName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Sttfile")]
    public virtual DynamicWedge AddOnSerNavigation { get; set; } = null!;
}
