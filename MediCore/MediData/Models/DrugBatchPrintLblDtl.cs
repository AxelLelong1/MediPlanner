﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DrugBatchId", "DrugBatchLblDtlId")]
[Table("drug_batch_print_lbl_dtl")]
public partial class DrugBatchPrintLblDtl
{
    [Key]
    [Column("drug_batch_id")]
    public int DrugBatchId { get; set; }

    [Key]
    [Column("drug_batch_lbl_dtl_id")]
    public int DrugBatchLblDtlId { get; set; }

    [Column("print_seq")]
    public int PrintSeq { get; set; }

    [Column("print_desc")]
    [StringLength(255)]
    public string PrintDesc { get; set; } = null!;

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
    [InverseProperty("DrugBatchPrintLblDtl")]
    public virtual DrugBatch DrugBatch { get; set; } = null!;

    [ForeignKey("DrugBatchLblDtlId")]
    [InverseProperty("DrugBatchPrintLblDtl")]
    public virtual DrugBatchLblDtl DrugBatchLblDtl { get; set; } = null!;
}