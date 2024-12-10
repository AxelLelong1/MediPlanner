using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("drug_batch_agt")]
public partial class DrugBatchAgt
{
    [Key]
    [Column("drug_batch_agt_id")]
    public int DrugBatchAgtId { get; set; }

    [Column("drug_batch_id")]
    public int DrugBatchId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("admn_dosage", TypeName = "numeric(11, 4)")]
    public decimal? AdmnDosage { get; set; }

    [Column("admn_dosage_unit")]
    public int? AdmnDosageUnit { get; set; }

    [Column("dose_strength")]
    [StringLength(15)]
    public string? DoseStrength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("admn_dosage_upper", TypeName = "numeric(11, 4)")]
    public decimal? AdmnDosageUpper { get; set; }

    [Column("agt_seq_no")]
    public int? AgtSeqNo { get; set; }

    [ForeignKey("DrugBatchId")]
    [InverseProperty("DrugBatchAgt")]
    public virtual DrugBatch DrugBatch { get; set; } = null!;

    [InverseProperty("DrugBatchAgt")]
    public virtual ICollection<DrugBatchUnitPt> DrugBatchUnitPt { get; set; } = new List<DrugBatchUnitPt>();

    [InverseProperty("DrugBatchAgt")]
    public virtual ICollection<StockTrx> StockTrx { get; set; } = new List<StockTrx>();
}
