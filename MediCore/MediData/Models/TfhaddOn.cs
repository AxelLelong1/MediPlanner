using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("RadiationHstrySer", "AddOnNumber")]
[Table("TFHAddOn")]
public partial class TfhaddOn
{
    [Key]
    public long RadiationHstrySer { get; set; }

    [Key]
    public int AddOnNumber { get; set; }

    [StringLength(16)]
    public string AddOnId { get; set; } = null!;

    [StringLength(30)]
    public string AddOnType { get; set; } = null!;

    [StringLength(64)]
    public string? AddOnSubType { get; set; }

    [ForeignKey("RadiationHstrySer")]
    [InverseProperty("TfhaddOn")]
    public virtual ExternalFieldCommonHstry RadiationHstrySerNavigation { get; set; } = null!;
}
