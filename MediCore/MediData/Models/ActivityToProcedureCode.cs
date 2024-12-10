using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivitySer", "ProcedureCodeSer")]
[Index("ProcedureCodeSer", Name = "XIF472E_694")]
public partial class ActivityToProcedureCode
{
    [Key]
    public long ActivitySer { get; set; }

    [Key]
    public long ProcedureCodeSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? SortOrder { get; set; }

    public int AutoAssign { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityToProcedureCode")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;

    [ForeignKey("ProcedureCodeSer")]
    [InverseProperty("ActivityToProcedureCode")]
    public virtual ProcedureCode ProcedureCodeSerNavigation { get; set; } = null!;
}
