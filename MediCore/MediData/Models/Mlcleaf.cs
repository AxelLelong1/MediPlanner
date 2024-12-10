using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MLCLeaf")]
[Index("MlcbankSer", "LeafNumber", Name = "XAK1MLCLeaf", IsUnique = true)]
[Index("MlcbankSer", "LeafId", Name = "XAK2MLCLeaf", IsUnique = true)]
public partial class Mlcleaf
{
    [Key]
    [Column("MLCLeafSer")]
    public long MlcleafSer { get; set; }

    [Column("MLCBankSer")]
    public long MlcbankSer { get; set; }

    [StringLength(16)]
    public string LeafId { get; set; } = null!;

    public int LeafNumber { get; set; }

    public double? OffsetY { get; set; }

    public double? MaxRetractPosition { get; set; }

    public double? MaxExtendPosition { get; set; }

    public double Width { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("MlcbankSer")]
    [InverseProperty("Mlcleaf")]
    public virtual Mlcbank MlcbankSerNavigation { get; set; } = null!;
}
