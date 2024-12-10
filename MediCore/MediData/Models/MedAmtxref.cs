using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ExternalSource", "ExternalSourceCode", "ConceptTypeId", "ConceptValue")]
[Table("med_amtxref")]
public partial class MedAmtxref
{
    [Key]
    [Column("external_source")]
    [StringLength(10)]
    [Unicode(false)]
    public string ExternalSource { get; set; } = null!;

    [Key]
    [Column("external_source_code")]
    [StringLength(30)]
    [Unicode(false)]
    public string ExternalSourceCode { get; set; } = null!;

    [Key]
    [Column("concept_type_id")]
    [StringLength(5)]
    [Unicode(false)]
    public string ConceptTypeId { get; set; } = null!;

    [Key]
    [Column("concept_value")]
    [StringLength(20)]
    [Unicode(false)]
    public string ConceptValue { get; set; } = null!;

    [Column("transaction_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [Column("match_type")]
    [StringLength(2)]
    [Unicode(false)]
    public string? MatchType { get; set; }

    [Column("umls_concept_id")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UmlsConceptId { get; set; }

    [Column("source_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SourceCode { get; set; }

    [Column("medispan_to_external_ind")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MedispanToExternalInd { get; set; }

    [Column("external_code_to_medispan_selection_ind")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExternalCodeToMedispanSelectionInd { get; set; }

    [Column("reserve")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Reserve { get; set; }
}
