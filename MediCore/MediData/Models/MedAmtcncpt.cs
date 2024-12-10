using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_amtcncpt")]
public partial class MedAmtcncpt
{
    [Key]
    [Column("concept_type_id")]
    [StringLength(5)]
    [Unicode(false)]
    public string ConceptTypeId { get; set; } = null!;

    [Column("transaction_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [Column("concept_type_desc")]
    [StringLength(35)]
    [Unicode(false)]
    public string? ConceptTypeDesc { get; set; }

    [Column("reserve")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Reserve { get; set; }
}
