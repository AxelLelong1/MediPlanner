using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BatchSetupId", "BillSysKeyOrderNo")]
[Table("bill_sys_batch_def")]
public partial class BillSysBatchDef
{
    [Key]
    [Column("batch_setup_id")]
    public int BatchSetupId { get; set; }

    [Key]
    [Column("bill_sys_key_order_no")]
    public int BillSysKeyOrderNo { get; set; }

    [Column("bill_sys_key_id")]
    public int BillSysKeyId { get; set; }

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

    [ForeignKey("BatchSetupId")]
    [InverseProperty("BillSysBatchDef")]
    public virtual BillSysBatchSetup BatchSetup { get; set; } = null!;

    [ForeignKey("BillSysKeyId")]
    [InverseProperty("BillSysBatchDef")]
    public virtual BillSysKeyCd BillSysKey { get; set; } = null!;
}
