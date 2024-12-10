using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TxTframeTyp", "IntvUseTyp", "EventTyp")]
[Table("tx_tframe_intv_use")]
public partial class TxTframeIntvUse
{
    [Key]
    [Column("tx_tframe_typ")]
    public int TxTframeTyp { get; set; }

    [Key]
    [Column("intv_use_typ")]
    public int IntvUseTyp { get; set; }

    [Key]
    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("tx_tframe_intv_use_desc")]
    [StringLength(40)]
    public string? TxTframeIntvUseDesc { get; set; }

    [Column("sort_order")]
    public int? SortOrder { get; set; }

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

    [ForeignKey("EventTyp")]
    [InverseProperty("TxTframeIntvUse")]
    public virtual EventTyp EventTypNavigation { get; set; } = null!;

    [ForeignKey("IntvUseTyp")]
    [InverseProperty("TxTframeIntvUse")]
    public virtual IntvUseTyp IntvUseTypNavigation { get; set; } = null!;

    [ForeignKey("TxTframeTyp")]
    [InverseProperty("TxTframeIntvUse")]
    public virtual TxTframeTyp TxTframeTypNavigation { get; set; } = null!;
}
