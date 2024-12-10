using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DerivedInstanceUID")]
[Index("InstanceUid", Name = "XIE2DerivedInstanceUID")]
[Index("SliceSer", Name = "XIF934DerivedInstanceUID")]
public partial class DerivedInstanceUid
{
    [Key]
    [Column("DerivedInstanceUIDSer")]
    public long DerivedInstanceUidser { get; set; }

    public long SliceSer { get; set; }

    [Column("InstanceUID")]
    [StringLength(64)]
    public string InstanceUid { get; set; } = null!;

    [ForeignKey("SliceSer")]
    [InverseProperty("DerivedInstanceUid")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
