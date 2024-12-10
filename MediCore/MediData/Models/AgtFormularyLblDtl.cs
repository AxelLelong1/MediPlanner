using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_formulary_lbl_dtl")]
public partial class AgtFormularyLblDtl
{
    [Key]
    [Column("agt_formulary_lbl_dtl_id")]
    public int AgtFormularyLblDtlId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int DosageForm { get; set; }

    [Column("admn_route")]
    public int AdmnRoute { get; set; }

    [Column("strength")]
    [StringLength(15)]
    public string? Strength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

    [Column("drug_batch_lbl_dtl_id")]
    public int DrugBatchLblDtlId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
