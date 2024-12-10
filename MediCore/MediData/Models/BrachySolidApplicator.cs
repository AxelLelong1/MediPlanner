using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanSetupSer", Name = "XIF914BrachySolidApplicator")]
public partial class BrachySolidApplicator
{
    [Key]
    public long BrachySolidApplicatorSer { get; set; }

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string BrachySolidApplicatorId { get; set; } = null!;

    [StringLength(64)]
    public string? BrachySolidApplicatorName { get; set; }

    [Column("ApplicatorPartUID")]
    [StringLength(64)]
    public string ApplicatorPartUid { get; set; } = null!;

    [StringLength(254)]
    public string ApplicatorPartFileName { get; set; } = null!;

    [MaxLength(96)]
    public byte[] Transformation { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("BrachySolidApplicatorSerNavigation")]
    public virtual ICollection<BrachyField> BrachyField { get; set; } = new List<BrachyField>();

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("BrachySolidApplicator")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;
}
