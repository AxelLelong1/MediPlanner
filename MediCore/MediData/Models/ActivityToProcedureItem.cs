using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ProcedureItemSer", Name = "XIF1ActivityToProcedureItem")]
[Index("ActivitySer", Name = "XIF2ActivityToProcedureItem")]
public partial class ActivityToProcedureItem
{
    [Key]
    public long ActivityToProcedureItemSer { get; set; }

    public long ActivitySer { get; set; }

    public long ProcedureItemSer { get; set; }

    public int AutoAssign { get; set; }

    public int? SortOrder { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityToProcedureItem")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;

    [ForeignKey("ProcedureItemSer")]
    [InverseProperty("ActivityToProcedureItem")]
    public virtual ProcedureItem ProcedureItemSerNavigation { get; set; } = null!;
}
