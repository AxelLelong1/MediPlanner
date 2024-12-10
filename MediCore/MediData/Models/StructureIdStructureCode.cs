using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TargetStructureCodeSer", Name = "XIF1StructureIdStructureCode")]
public partial class StructureIdStructureCode
{
    [Key]
    public long StructureIdStructureCodeSer { get; set; }

    [StringLength(32)]
    public string StructureIdPattern { get; set; } = null!;

    public long TargetStructureCodeSer { get; set; }

    [StringLength(128)]
    public string? MappingContext { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("TargetStructureCodeSer")]
    [InverseProperty("StructureIdStructureCode")]
    public virtual StructureCode TargetStructureCodeSerNavigation { get; set; } = null!;
}
