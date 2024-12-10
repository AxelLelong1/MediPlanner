using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillSysInstId", "BillSysId", "InstId", "BillCdTyp", "BillCd")]
[Table("inst_bill_cd_info")]
public partial class InstBillCdInfo
{
    [Key]
    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string BillSysInstId { get; set; } = null!;

    [Key]
    [Column("bill_sys_id")]
    [StringLength(20)]
    public string BillSysId { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("bill_cd_typ")]
    public int BillCdTyp { get; set; }

    [Key]
    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd { get; set; } = null!;

    [Column("bill_sys_bill_cd_typ")]
    [StringLength(10)]
    public string? BillSysBillCdTyp { get; set; }

    [Column("bill_sys_bill_cd")]
    [StringLength(30)]
    public string? BillSysBillCd { get; set; }

    [Column("bill_cd_eff_dt", TypeName = "datetime")]
    public DateTime? BillCdEffDt { get; set; }

    [Column("bill_cd_term_dt", TypeName = "datetime")]
    public DateTime? BillCdTermDt { get; set; }

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

    [ForeignKey("BillSysInstId, BillSysId")]
    [InverseProperty("InstBillCdInfo")]
    public virtual BillSystem BillSystem { get; set; } = null!;
}
