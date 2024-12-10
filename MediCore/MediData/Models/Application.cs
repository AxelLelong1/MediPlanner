using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ApplicationDesc", Name = "XAK1Application", IsUnique = true)]
public partial class Application
{
    [Key]
    public long ApplicationSer { get; set; }

    [StringLength(64)]
    public string ApplicationDesc { get; set; } = null!;

    [StringLength(254)]
    public string? ApplicationNote { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ApplicationSerNavigation")]
    public virtual ICollection<ApplicationPrintReport> ApplicationPrintReport { get; set; } = new List<ApplicationPrintReport>();
}
