using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TargetStructureCodeSer", Name = "XIF1CodeStructureCode")]
public partial class CodeStructureCode
{
    [Key]
    public long CodeStructureCodeSer { get; set; }

    [StringLength(16)]
    public string SourceCodeScheme { get; set; } = null!;

    [StringLength(16)]
    public string SourceCodeValue { get; set; } = null!;

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
    [InverseProperty("CodeStructureCode")]
    public virtual StructureCode TargetStructureCodeSerNavigation { get; set; } = null!;
}
