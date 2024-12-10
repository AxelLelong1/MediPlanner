using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ActivityCodeMd
{
    [Key]
    public long ModifierSer { get; set; }

    public int ActivityCodeMdRevCount { get; set; }

    [StringLength(64)]
    public string Modifier { get; set; } = null!;

    public double? MdfrMultiplier { get; set; }

    [StringLength(64)]
    public string Description { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("Modifier2SerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifier2SerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("Modifier3SerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifier3SerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("Modifier4SerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifier4SerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("Modifier5SerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifier5SerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("Modifier6SerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifier6SerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("Modifier7SerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifier7SerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("ModifierSerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCodeModifierSerNavigation { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("ModifierSerNavigation")]
    public virtual ICollection<ActivityCodeMdMh> ActivityCodeMdMh { get; set; } = new List<ActivityCodeMdMh>();

    [InverseProperty("ModifierSerNavigation")]
    public virtual ICollection<ProcedureCode> ProcedureCode { get; set; } = new List<ProcedureCode>();
}
