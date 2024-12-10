using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Directive
{
    [Key]
    public long DirectiveSer { get; set; }

    [StringLength(254)]
    public string Description { get; set; } = null!;

    public int ActiveFlag { get; set; }

    public int ConfirmFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("DirectiveSerNavigation")]
    public virtual ICollection<PatientDirective> PatientDirective { get; set; } = new List<PatientDirective>();
}
