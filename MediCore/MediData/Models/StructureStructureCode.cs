using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StructureSer", "StructureCodeSer")]
[Index("StructureSer", Name = "XIF1StructureStructureCode")]
[Index("StructureCodeSer", Name = "XIF2StructureStructureCode")]
public partial class StructureStructureCode
{
    [Key]
    public long StructureSer { get; set; }

    [Key]
    public long StructureCodeSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("StructureCodeSer")]
    [InverseProperty("StructureStructureCode")]
    public virtual StructureCode StructureCodeSerNavigation { get; set; } = null!;

    [ForeignKey("StructureSer")]
    [InverseProperty("StructureStructureCode")]
    public virtual Structure StructureSerNavigation { get; set; } = null!;
}
