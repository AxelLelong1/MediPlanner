using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tx_tframe_typ")]
public partial class TxTframeTyp
{
    [Key]
    [Column("tx_tframe_typ")]
    public int TxTframeTyp1 { get; set; }

    [Column("tx_tframe_typ_desc")]
    [StringLength(40)]
    public string? TxTframeTypDesc { get; set; }

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

    [InverseProperty("TxTframeTypNavigation")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();

    [InverseProperty("TxTframeTypNavigation")]
    public virtual ICollection<TxTframeIntvUse> TxTframeIntvUse { get; set; } = new List<TxTframeIntvUse>();
}
