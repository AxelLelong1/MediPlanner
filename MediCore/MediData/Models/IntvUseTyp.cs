using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intv_use_typ")]
public partial class IntvUseTyp
{
    [Key]
    [Column("intv_use_typ")]
    public int IntvUseTyp1 { get; set; }

    [Column("intv_use_typ_desc")]
    [StringLength(40)]
    public string? IntvUseTypDesc { get; set; }

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

    [InverseProperty("IntvUseTypNavigation")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();

    [InverseProperty("IntvUseTypNavigation")]
    public virtual ICollection<TxTframeIntvUse> TxTframeIntvUse { get; set; } = new List<TxTframeIntvUse>();
}
