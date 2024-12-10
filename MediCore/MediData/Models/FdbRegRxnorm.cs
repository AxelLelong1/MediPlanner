using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FdbRxnormId", "RegionCode", "LanguageId")]
[Table("FDB_reg_rxnorm")]
public partial class FdbRegRxnorm
{
    [Key]
    [Column("fdb_rxnorm_id")]
    public int FdbRxnormId { get; set; }

    [Key]
    [Column("region_code")]
    public int RegionCode { get; set; }

    [Key]
    [Column("language_id")]
    public int LanguageId { get; set; }

    [Column("fdb_agent_id")]
    [StringLength(32)]
    public string FdbAgentId { get; set; } = null!;

    [Column("rxnorm_id")]
    [StringLength(30)]
    public string RxnormId { get; set; } = null!;

    [Column("umls_concept_id")]
    [StringLength(12)]
    public string? UmlsConceptId { get; set; }
}
