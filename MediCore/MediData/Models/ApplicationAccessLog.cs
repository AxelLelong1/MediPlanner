using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HstryDateTime", "LoginName", Name = "XIE1ApplicationAccessLog")]
public partial class ApplicationAccessLog
{
    [Key]
    public long ApplicationAccessLogSer { get; set; }

    public int Spid { get; set; }

    public int Suid { get; set; }

    [StringLength(32)]
    public string LoginName { get; set; } = null!;

    [StringLength(64)]
    public string ApplicationName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(254)]
    public string? ExtraInfo { get; set; }
}
