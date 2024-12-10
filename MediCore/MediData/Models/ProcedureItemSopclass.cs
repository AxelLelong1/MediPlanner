using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ProcedureItemSOPClass")]
[Index("ProcedureItemSer", Name = "XIF1ProcedureItemSOPClass")]
[Index("SopclassSer", Name = "XIF2ProcedureItemSOPClass")]
public partial class ProcedureItemSopclass
{
    [Key]
    [Column("ProcedureItemSOPClassSer")]
    public long ProcedureItemSopclassSer { get; set; }

    public long ProcedureItemSer { get; set; }

    [Column("SOPClassSer")]
    public long? SopclassSer { get; set; }

    [StringLength(30)]
    public string? TableName { get; set; }

    [StringLength(32)]
    public string Type { get; set; } = null!;

    public long? InputTemplateSer { get; set; }

    public int? RequiredFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ProcedureItemSer")]
    [InverseProperty("ProcedureItemSopclass")]
    public virtual ProcedureItem ProcedureItemSerNavigation { get; set; } = null!;

    [ForeignKey("SopclassSer")]
    [InverseProperty("ProcedureItemSopclass")]
    public virtual Sopclass? SopclassSerNavigation { get; set; }
}
