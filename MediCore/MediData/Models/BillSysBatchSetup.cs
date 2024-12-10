using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_sys_batch_setup")]
public partial class BillSysBatchSetup
{
    [Key]
    [Column("batch_setup_id")]
    public int BatchSetupId { get; set; }

    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string BillSysInstId { get; set; } = null!;

    [Column("bill_sys_id")]
    [StringLength(20)]
    public string BillSysId { get; set; } = null!;

    [Column("batch_setup_desc")]
    [StringLength(80)]
    public string BatchSetupDesc { get; set; } = null!;

    [Column("batch_setup_order_no")]
    public int BatchSetupOrderNo { get; set; }

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

    [InverseProperty("BatchSetup")]
    public virtual ICollection<BillSysBatchDef> BillSysBatchDef { get; set; } = new List<BillSysBatchDef>();

    [InverseProperty("BatchSetup")]
    public virtual ICollection<BillSysBatchGroup> BillSysBatchGroup { get; set; } = new List<BillSysBatchGroup>();

    [ForeignKey("BillSysInstId, BillSysId")]
    [InverseProperty("BillSysBatchSetup")]
    public virtual BillSystem BillSystem { get; set; } = null!;
}
