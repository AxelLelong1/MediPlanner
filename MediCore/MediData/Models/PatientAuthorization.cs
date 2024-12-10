using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientPayorSer", "PatientPayorRevCount", "AuthorizationDateTime", Name = "XAK1PatientAuthorization", IsUnique = true)]
public partial class PatientAuthorization
{
    [Key]
    public long PatientAuthorizationSer { get; set; }

    public long PatientPayorSer { get; set; }

    public int PatientPayorRevCount { get; set; }

    [StringLength(16)]
    public string? AuthorizationId { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AuthorizationDateTime { get; set; }

    [StringLength(64)]
    public string? AuthorizedBy { get; set; }

    [StringLength(64)]
    public string? AuthorizationPhone { get; set; }

    [Column("AuthorizationFAX")]
    [StringLength(64)]
    public string? AuthorizationFax { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientPayorSer")]
    [InverseProperty("PatientAuthorization")]
    public virtual PatientPayor PatientPayorSerNavigation { get; set; } = null!;
}
