using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ExternalIntegration
{
    [Key]
    public long ExternalIntegrationSer { get; set; }

    [StringLength(30)]
    public string VarisType { get; set; } = null!;

    public long VarisSer { get; set; }

    [StringLength(32)]
    public string ExternalApplication { get; set; } = null!;

    [Column("ExternalID")]
    [StringLength(512)]
    public string ExternalId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("AuthenticationID")]
    [StringLength(128)]
    public string? AuthenticationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [StringLength(1024)]
    public string? AdditionalInfo { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
