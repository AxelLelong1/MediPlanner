using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_em_risk_typ")]
public partial class BillEmRiskTyp
{
    [Key]
    [Column("bill_em_risk_typ")]
    public int BillEmRiskTyp1 { get; set; }

    [Column("bill_em_risk_desc")]
    [StringLength(40)]
    public string BillEmRiskDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("MdmRiskTypNavigation")]
    public virtual ICollection<BillEventEmInfo> BillEventEmInfo { get; set; } = new List<BillEventEmInfo>();
}
