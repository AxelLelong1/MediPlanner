using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ConceptTypeId1", "ConceptValue1", "ConceptTypeId2", "ConceptValue2")]
[Table("med_amtinrel")]
public partial class MedAmtinrel
{
    [Key]
    [Column("concept_type_id_1")]
    [StringLength(5)]
    [Unicode(false)]
    public string ConceptTypeId1 { get; set; } = null!;

    [Key]
    [Column("concept_value_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string ConceptValue1 { get; set; } = null!;

    [Key]
    [Column("concept_type_id_2")]
    [StringLength(5)]
    [Unicode(false)]
    public string ConceptTypeId2 { get; set; } = null!;

    [Key]
    [Column("concept_value_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string ConceptValue2 { get; set; } = null!;

    [Column("transaction_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [Column("reserve_1")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Reserve1 { get; set; }

    [Column("detailed_relationship_2_to_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DetailedRelationship2To1 { get; set; }

    [Column("reserve_2")]
    [StringLength(45)]
    [Unicode(false)]
    public string? Reserve2 { get; set; }
}
