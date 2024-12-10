using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_rxnorm")]
public partial class MedRxnorm
{
    [Key]
    [Column("med_rxnorm_id")]
    public int MedRxnormId { get; set; }

    [Column("drug_desc_id")]
    [StringLength(20)]
    public string DrugDescId { get; set; } = null!;

    [Column("rxnorm_id")]
    [StringLength(30)]
    public string RxnormId { get; set; } = null!;

    [Column("match_typ")]
    [StringLength(2)]
    public string MatchTyp { get; set; } = null!;

    [Column("umls_concept_id")]
    [StringLength(12)]
    public string UmlsConceptId { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
