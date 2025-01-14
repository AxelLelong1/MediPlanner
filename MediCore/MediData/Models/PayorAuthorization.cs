﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PayorSer", Name = "XIF402PayorAuthrztn")]
public partial class PayorAuthorization
{
    [Key]
    public long PayorAuthorizationSer { get; set; }

    public long PayorSer { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

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

    [ForeignKey("PayorSer")]
    [InverseProperty("PayorAuthorization")]
    public virtual Payor PayorSerNavigation { get; set; } = null!;
}
