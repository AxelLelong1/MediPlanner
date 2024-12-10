using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacGroupId", "FacGroupBillId")]
[Table("fac_group_bill")]
public partial class FacGroupBill
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_group_id")]
    public int FacGroupId { get; set; }

    [Key]
    [Column("fac_group_bill_id")]
    public int FacGroupBillId { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd { get; set; } = null!;

    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Column("bill_instance_id")]
    public int BillInstanceId { get; set; }

    [Column("bill_qty")]
    public int BillQty { get; set; }

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

    [ForeignKey("InstId, FacId, FacGroupId")]
    [InverseProperty("FacGroupBill")]
    public virtual FacGroup FacGroup { get; set; } = null!;
}
