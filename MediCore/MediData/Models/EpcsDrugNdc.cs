using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("epcs_drug_ndc")]
public partial class EpcsDrugNdc
{
    [Key]
    [Column("epcs_drug_ndc_id")]
    public int EpcsDrugNdcId { get; set; }

    [Column("drug_name")]
    [StringLength(105)]
    public string DrugName { get; set; } = null!;

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [Column("strength")]
    [StringLength(15)]
    public string? Strength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

    [Column("ndc_cd")]
    [StringLength(20)]
    public string NdcCd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(10)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(10)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
