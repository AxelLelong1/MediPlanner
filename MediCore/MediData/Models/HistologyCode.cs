using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class HistologyCode
{
    [StringLength(64)]
    public string? HistologyTableName { get; set; }

    [Column("HistologyCode")]
    [StringLength(16)]
    public string HistologyCode1 { get; set; } = null!;

    [StringLength(16)]
    public string? LanguageId { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(32)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [MaxLength(8)]
    public byte[] HstryTimeStamp { get; set; } = null!;

    [StringLength(16)]
    public string? UpperHistologyCode { get; set; }

    [StringLength(254)]
    public string? UpperDescription { get; set; }
}
