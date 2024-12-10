using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("drug_batch_unit_pt")]
public partial class DrugBatchUnitPt
{
    [Key]
    [Column("drug_batch_unit_pt_id")]
    public int DrugBatchUnitPtId { get; set; }

    [Column("drug_batch_unit_id")]
    public int DrugBatchUnitId { get; set; }

    [Column("drug_batch_id")]
    public int DrugBatchId { get; set; }

    [Column("drug_batch_agt_id")]
    public int DrugBatchAgtId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("rx_id")]
    public int? RxId { get; set; }

    [Column("item_no")]
    public int? ItemNo { get; set; }

    [Column("admn_id")]
    public int? AdmnId { get; set; }

    [Column("expected_dose_date", TypeName = "datetime")]
    public DateTime? ExpectedDoseDate { get; set; }

    [Column("dose_seq_no")]
    public int? DoseSeqNo { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("intv_id")]
    public int? IntvId { get; set; }

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

    [ForeignKey("DrugBatchAgtId")]
    [InverseProperty("DrugBatchUnitPt")]
    public virtual DrugBatchAgt DrugBatchAgt { get; set; } = null!;

    [ForeignKey("DrugBatchUnitId")]
    [InverseProperty("DrugBatchUnitPt")]
    public virtual DrugBatchUnit DrugBatchUnit { get; set; } = null!;
}
