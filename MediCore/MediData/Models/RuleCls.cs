using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("rule_cls")]
public partial class RuleCls
{
    [Key]
    [Column("rule_cls_typ")]
    public int RuleClsTyp { get; set; }

    [Column("rule_cls_desc")]
    [StringLength(40)]
    public string RuleClsDesc { get; set; } = null!;

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

    [InverseProperty("RuleClsTypNavigation")]
    public virtual ICollection<RbObjAttrCls> RbObjAttrCls { get; set; } = new List<RbObjAttrCls>();
}
