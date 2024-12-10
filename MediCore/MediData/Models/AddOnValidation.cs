using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ConfiguredEmtser", "AddOnSer")]
[Index("AddOnSer", Name = "XIF530AddOnValidation")]
public partial class AddOnValidation
{
    [Key]
    [Column("ConfiguredEMTSer")]
    public long ConfiguredEmtser { get; set; }

    [Key]
    public long AddOnSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("AddOnValidation")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [ForeignKey("ConfiguredEmtser")]
    [InverseProperty("AddOnValidation")]
    public virtual ConfiguredEmt ConfiguredEmtserNavigation { get; set; } = null!;
}
