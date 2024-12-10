using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RadiationSer", "StructureSer", Name = "XIE3FieldStructure")]
[Index("StructureSer", Name = "XIF946FieldStructure")]
[Index("BlockSer", Name = "XIF948FieldStructure")]
public partial class FieldStructure
{
    [Key]
    public long FieldStructureSer { get; set; }

    public long RadiationSer { get; set; }

    public long StructureSer { get; set; }

    [StringLength(16)]
    public string? StructUsageType { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? BlockSer { get; set; }

    [StringLength(64)]
    public string? CustomCode { get; set; }

    [ForeignKey("BlockSer")]
    [InverseProperty("FieldStructure")]
    public virtual Block? BlockSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("FieldStructure")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("StructureSer")]
    [InverseProperty("FieldStructure")]
    public virtual Structure StructureSerNavigation { get; set; } = null!;
}
