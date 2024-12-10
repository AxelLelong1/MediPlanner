using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class DemGroup
{
    [Key]
    public long DemGroupSer { get; set; }

    [StringLength(16)]
    public string DemGroupId { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("DemGroupSerNavigation")]
    public virtual ICollection<DemExternalBeam> DemExternalBeam { get; set; } = new List<DemExternalBeam>();
}
