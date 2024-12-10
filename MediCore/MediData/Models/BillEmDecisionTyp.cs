using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_em_decision_typ")]
public partial class BillEmDecisionTyp
{
    [Key]
    [Column("bill_em_decision_typ")]
    public int BillEmDecisionTyp1 { get; set; }

    [Column("bill_em_decision_desc")]
    [StringLength(40)]
    public string BillEmDecisionDesc { get; set; } = null!;

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

    [InverseProperty("MdmDecisionTypNavigation")]
    public virtual ICollection<BillEventEmInfo> BillEventEmInfo { get; set; } = new List<BillEventEmInfo>();
}
