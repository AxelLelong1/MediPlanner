using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_xref_allergy_rxnorm")]
public partial class QmXrefAllergyRxnorm
{
    [Key]
    [Column("allergy_rxnorm_id")]
    public int AllergyRxnormId { get; set; }

    [Column("rxnorm_id")]
    [StringLength(30)]
    public string RxnormId { get; set; } = null!;

    [Column("allergy_desc")]
    [StringLength(50)]
    public string AllergyDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
