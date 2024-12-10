using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("db_printer_mutex")]
[Index("PrinterName", Name = "nc1_db_printer_mutex")]
public partial class DbPrinterMutex
{
    [Key]
    [Column("printer_mutex_id")]
    public int PrinterMutexId { get; set; }

    [Column("printer_name")]
    [StringLength(256)]
    public string PrinterName { get; set; } = null!;

    [Column("printer_status_ind")]
    [StringLength(1)]
    public string PrinterStatusInd { get; set; } = null!;

    [Column("printer_status_tstamp", TypeName = "datetime")]
    public DateTime PrinterStatusTstamp { get; set; }

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
