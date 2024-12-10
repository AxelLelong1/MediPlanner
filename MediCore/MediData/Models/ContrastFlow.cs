﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ContrastBolusSer", "FlowIndex", Name = "XAK1ContrastFlow", IsUnique = true)]
public partial class ContrastFlow
{
    [Key]
    public long ContrastFlowSer { get; set; }

    public long ContrastBolusSer { get; set; }

    public int FlowIndex { get; set; }

    public double FlowRate { get; set; }

    public double FlowDuration { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ContrastBolusSer")]
    [InverseProperty("ContrastFlow")]
    public virtual ContrastBolus ContrastBolusSerNavigation { get; set; } = null!;
}
