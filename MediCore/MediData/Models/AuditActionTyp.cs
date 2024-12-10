using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("audit_action_typ")]
public partial class AuditActionTyp
{
    [Key]
    [Column("audit_action_typ")]
    public int AuditActionTyp1 { get; set; }

    [Column("audit_action_desc")]
    [StringLength(40)]
    public string AuditActionDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("AuditActionTypNavigation")]
    public virtual ICollection<AuditRec> AuditRec { get; set; } = new List<AuditRec>();
}
