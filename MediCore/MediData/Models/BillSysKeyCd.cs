using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_sys_key_cd")]
public partial class BillSysKeyCd
{
    [Key]
    [Column("bill_sys_key_id")]
    public int BillSysKeyId { get; set; }

    [Column("bill_sys_key_desc")]
    [StringLength(60)]
    public string BillSysKeyDesc { get; set; } = null!;

    [Column("bill_sys_key_col_name")]
    [StringLength(40)]
    public string BillSysKeyColName { get; set; } = null!;

    [Column("dddw_name")]
    [StringLength(30)]
    public string? DddwName { get; set; }

    [Column("dddw_disp_name")]
    [StringLength(30)]
    public string? DddwDispName { get; set; }

    [Column("dddw_data_name")]
    [StringLength(30)]
    public string? DddwDataName { get; set; }

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

    [InverseProperty("BillSysKey")]
    public virtual ICollection<BillSysBatchDef> BillSysBatchDef { get; set; } = new List<BillSysBatchDef>();
}
