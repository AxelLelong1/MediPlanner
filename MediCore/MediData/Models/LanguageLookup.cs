using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class LanguageLookup
{
    [Key]
    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [StringLength(64)]
    public string? LanguageName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("Language")]
    public virtual ICollection<AppUser> AppUser { get; set; } = new List<AppUser>();

    [InverseProperty("Language")]
    public virtual ICollection<ErrorMsg> ErrorMsg { get; set; } = new List<ErrorMsg>();

    [InverseProperty("Language")]
    public virtual ICollection<LookupTable> LookupTable { get; set; } = new List<LookupTable>();

    [InverseProperty("Language")]
    public virtual ICollection<VolumeCode> VolumeCode { get; set; } = new List<VolumeCode>();
}
