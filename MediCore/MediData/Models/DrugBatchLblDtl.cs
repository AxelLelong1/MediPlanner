using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("drug_batch_lbl_dtl")]
public partial class DrugBatchLblDtl
{
    [Key]
    [Column("drug_batch_lbl_dtl_id")]
    public int DrugBatchLblDtlId { get; set; }

    [Column("drug_batch_lbl_dtl_desc")]
    [StringLength(255)]
    public string DrugBatchLblDtlDesc { get; set; } = null!;

    [Column("drug_batch_lbl_dtl_desc_cust")]
    [StringLength(255)]
    public string DrugBatchLblDtlDescCust { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

    [Column("seq_no")]
    public int SeqNo { get; set; }

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

    [InverseProperty("DrugBatchLblDtl")]
    public virtual ICollection<DrugBatchPrintLblDtl> DrugBatchPrintLblDtl { get; set; } = new List<DrugBatchPrintLblDtl>();
}
