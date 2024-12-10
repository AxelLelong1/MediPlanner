using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("CorrectionDateTime", Name = "XIE1DoseCorrectionLog")]
public partial class DoseCorrectionLog
{
    [Key]
    public long DoseCorrectionLogSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CorrectionDateTime { get; set; }

    [StringLength(254)]
    public string? CorrectionNote { get; set; }

    public int PrintFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("DoseCorrectionLogSerNavigation")]
    public virtual ICollection<RefPointLog> RefPointLog { get; set; } = new List<RefPointLog>();
}
