using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("drug_batch_print")]
public partial class DrugBatchPrint
{
    [Key]
    [Column("drug_batch_print_id")]
    public int DrugBatchPrintId { get; set; }

    [Column("drug_batch_id")]
    public int DrugBatchId { get; set; }

    [Column("printout_typ")]
    [StringLength(1)]
    public string PrintoutTyp { get; set; } = null!;

    [Column("date_printed", TypeName = "datetime")]
    public DateTime DatePrinted { get; set; }

    [Column("reprint_ind")]
    [StringLength(1)]
    public string? ReprintInd { get; set; }

    [Column("reprint_cmt")]
    [StringLength(255)]
    public string? ReprintCmt { get; set; }

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
    [InverseProperty("DrugBatchPrint")]
    public virtual DrugBatch DrugBatch { get; set; } = null!;
}
