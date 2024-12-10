using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("UserId", Name = "XAK1AppUser", IsUnique = true)]
[Index("UserCuid", Name = "XAK2AppUser", IsUnique = true)]
[Index("LanguageId", Name = "XIF791AppUser")]
[Index("ResourceSer", Name = "XIF799AppUser")]
public partial class AppUser
{
    [Key]
    public long AppUserSer { get; set; }

    [Column("UserCUID")]
    [StringLength(64)]
    public string UserCuid { get; set; } = null!;

    [StringLength(255)]
    public string UserId { get; set; } = null!;

    public long? ResourceSer { get; set; }

    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("AppUserSerNavigation")]
    public virtual ICollection<ConfigurationSet> ConfigurationSet { get; set; } = new List<ConfigurationSet>();

    [ForeignKey("LanguageId")]
    [InverseProperty("AppUser")]
    public virtual LanguageLookup Language { get; set; } = null!;

    [InverseProperty("AppUserSerNavigation")]
    public virtual ICollection<PatientListQueryConfiguration> PatientListQueryConfiguration { get; set; } = new List<PatientListQueryConfiguration>();

    [InverseProperty("AppUserSerNavigation")]
    public virtual ICollection<Report> Report { get; set; } = new List<Report>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("AppUser")]
    public virtual Resource? ResourceSerNavigation { get; set; }
}
