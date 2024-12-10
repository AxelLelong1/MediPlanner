using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DCTransferSyntax")]
[Index("DctransferSyntaxUid", Name = "XAK1DCTransferSyntax", IsUnique = true)]
public partial class DctransferSyntax
{
    [Key]
    [Column("DCTransferSyntaxSer")]
    public long DctransferSyntaxSer { get; set; }

    [Column("DCTransferSyntaxUID")]
    [StringLength(64)]
    public string DctransferSyntaxUid { get; set; } = null!;

    [InverseProperty("DctransferSyntaxSerNavigation")]
    public virtual ICollection<Slice> Slice { get; set; } = new List<Slice>();
}
