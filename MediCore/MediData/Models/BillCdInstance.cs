using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillCd", "BillCdTypId", "BillInstanceId")]
[Table("bill_cd_instance")]
public partial class BillCdInstance
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

    [Column("bill_instance_desc")]
    [StringLength(30)]
    public string? BillInstanceDesc { get; set; }

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

    [InverseProperty("BillCdInstance")]
    public virtual ICollection<BillCdInfo> BillCdInfo { get; set; } = new List<BillCdInfo>();

    [ForeignKey("BillCd, BillCdTypId")]
    [InverseProperty("BillCdInstance")]
    public virtual BillCd BillCdNavigation { get; set; } = null!;

    [InverseProperty("BillCdInstance")]
    public virtual ICollection<BillVisitEvent> BillVisitEvent { get; set; } = new List<BillVisitEvent>();

    [InverseProperty("BillCdInstance")]
    public virtual BillVisitTyp? BillVisitTyp { get; set; }

    [InverseProperty("BillCdInstance")]
    public virtual ICollection<HcpBill> HcpBill { get; set; } = new List<HcpBill>();
}
