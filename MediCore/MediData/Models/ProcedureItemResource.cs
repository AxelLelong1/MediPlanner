using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ProcedureItemSer", Name = "XIF1ProcedureItemResource")]
[Index("ResourceSer", Name = "XIF2ProcedureItemResource")]
[Index("ResourceGroupSer", Name = "XIF3ProcedureItemResource")]
public partial class ProcedureItemResource
{
    [Key]
    public long ProcedureItemResourceSer { get; set; }

    public long ProcedureItemSer { get; set; }

    public long? ResourceSer { get; set; }

    public long? ResourceGroupSer { get; set; }

    [StringLength(16)]
    public string? Modality { get; set; }

    public int NoEditFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ProcedureItemSer")]
    [InverseProperty("ProcedureItemResource")]
    public virtual ProcedureItem ProcedureItemSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceGroupSer")]
    [InverseProperty("ProcedureItemResource")]
    public virtual ResourceGroup? ResourceGroupSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("ProcedureItemResource")]
    public virtual Resource? ResourceSerNavigation { get; set; }
}
