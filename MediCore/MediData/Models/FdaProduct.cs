using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ApplNo", "ProductNo", "ProductMktStatus")]
[Table("FDA_product")]
[Index("DrugName", Name = "nc1_FDA_product")]
public partial class FdaProduct
{
    [Key]
    [StringLength(6)]
    public string ApplNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    public string ProductNo { get; set; } = null!;

    [Key]
    public int ProductMktStatus { get; set; }

    [StringLength(255)]
    public string? Form { get; set; }

    [StringLength(240)]
    public string? Dosage { get; set; }

    [Column("TECode")]
    [StringLength(100)]
    public string? Tecode { get; set; }

    [StringLength(1)]
    public string? ReferenceDrug { get; set; }

    [StringLength(125)]
    public string? DrugName { get; set; }

    [StringLength(255)]
    public string? Activeingred { get; set; }
}
