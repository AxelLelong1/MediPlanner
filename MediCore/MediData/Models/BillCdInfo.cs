using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillCd", "BillCdTypId", "BillInstanceId", "BillCdEfcDt")]
[Table("bill_cd_info")]
public partial class BillCdInfo
{
    [Key]
    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd { get; set; } = null!;

    [Key]
    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Key]
    [Column("bill_instance_id")]
    public int BillInstanceId { get; set; }

    [Key]
    [Column("bill_cd_efc_dt", TypeName = "datetime")]
    public DateTime BillCdEfcDt { get; set; }

    [Column("bill_cd_est_cost", TypeName = "decimal(8, 2)")]
    public decimal? BillCdEstCost { get; set; }

    [Column("bill_cd_bill_price", TypeName = "decimal(8, 2)")]
    public decimal? BillCdBillPrice { get; set; }

    [Column("bill_cd_inv_id")]
    [StringLength(30)]
    public string? BillCdInvId { get; set; }

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

    [ForeignKey("BillCd, BillCdTypId, BillInstanceId")]
    [InverseProperty("BillCdInfo")]
    public virtual BillCdInstance BillCdInstance { get; set; } = null!;
}
