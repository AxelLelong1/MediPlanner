using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PlanConcurrency
{
    [Key]
    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    [Column("LastSaveCRC")]
    [MaxLength(32)]
    public byte[] LastSaveCrc { get; set; } = null!;

    [Column("LastITLoadCRC")]
    [MaxLength(32)]
    public byte[]? LastItloadCrc { get; set; }

    public int CheckSumSource { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UserDecidedAbortPartialOnDate { get; set; }
}
