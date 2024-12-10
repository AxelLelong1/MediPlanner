using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("drug_batch_unit")]
public partial class DrugBatchUnit
{
    [Key]
    [Column("drug_batch_unit_id")]
    public int DrugBatchUnitId { get; set; }

    [Column("drug_batch_id")]
    public int DrugBatchId { get; set; }

    [Column("linked_to_pt_ind")]
    [StringLength(1)]
    public string? LinkedToPtInd { get; set; }

    [Column("dispensed_ind")]
    [StringLength(1)]
    public string? DispensedInd { get; set; }

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

    [ForeignKey("DrugBatchId")]
    [InverseProperty("DrugBatchUnit")]
    public virtual DrugBatch DrugBatch { get; set; } = null!;

    [InverseProperty("DrugBatchUnit")]
    public virtual ICollection<DrugBatchUnitPt> DrugBatchUnitPt { get; set; } = new List<DrugBatchUnitPt>();
}
