using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RTAppExtension")]
[Index("FullName", Name = "UQ_RTAppExtension_FullName", IsUnique = true)]
public partial class RtappExtension
{
    [Key]
    [Column("RTAppExtensionSer")]
    public long RtappExtensionSer { get; set; }

    [StringLength(1024)]
    public string FullName { get; set; } = null!;

    [StringLength(64)]
    public string ExtensionType { get; set; } = null!;

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [StringLength(255)]
    public string StatusUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [StringLength(254)]
    public string? PublisherName { get; set; }

    [MaxLength(32)]
    public byte[] CheckSum { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("RtappExtensionSerNavigation")]
    public virtual ICollection<RtappExtensionLog> RtappExtensionLog { get; set; } = new List<RtappExtensionLog>();
}
