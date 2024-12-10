using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AgtBillId")]
[Table("agt_bill")]
public partial class AgtBill
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agt_bill_id")]
    public int AgtBillId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string? AgtName { get; set; }

    [Column("route")]
    public int? Route { get; set; }

    [Column("form")]
    public int? Form { get; set; }

    [Column("dose_amt", TypeName = "numeric(11, 4)")]
    public decimal? DoseAmt { get; set; }

    [Column("dose_uom")]
    public int? DoseUom { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string? BillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }

    [Column("bill_instance_id")]
    public int? BillInstanceId { get; set; }

    [Column("bill_qty")]
    public int? BillQty { get; set; }

    [Column("fixed_qty_ind")]
    [StringLength(1)]
    public string? FixedQtyInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
