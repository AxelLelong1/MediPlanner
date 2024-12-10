using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ResourceDirect
{
    [Key]
    public long ResourceDirectSer { get; set; }

    public long? ResourceSer { get; set; }

    [StringLength(255)]
    public string? UserId { get; set; }

    [StringLength(30)]
    public string? InstId { get; set; }

    [StringLength(256)]
    public string? SmtpEmail { get; set; }

    [StringLength(255)]
    public string? SmtpPassword { get; set; }

    [StringLength(256)]
    public string? NotificationEmail { get; set; }
}
