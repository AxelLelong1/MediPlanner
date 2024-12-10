using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MLCBank")]
[Index("AddOnSer", "MlcbankId", Name = "XAKMLCBank", IsUnique = true)]
public partial class Mlcbank
{
    [Key]
    [Column("MLCBankSer")]
    public long MlcbankSer { get; set; }

    [Column("MLCBankId")]
    [StringLength(16)]
    public string MlcbankId { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long AddOnSer { get; set; }

    public double? MaxLeafExposure { get; set; }

    public double? MaxLeafSpan { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Mlcbank")]
    public virtual Mlc AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("MlcbankSerNavigation")]
    public virtual ICollection<Mlcleaf> Mlcleaf { get; set; } = new List<Mlcleaf>();
}
