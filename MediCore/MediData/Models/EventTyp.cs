using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("event_typ")]
public partial class EventTyp
{
    [Key]
    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp1 { get; set; } = null!;

    [Column("event_name")]
    [StringLength(40)]
    public string EventName { get; set; } = null!;

    [Column("event_desc")]
    [StringLength(100)]
    public string EventDesc { get; set; } = null!;

    [Column("gnrc_intv_ind")]
    [StringLength(1)]
    public string? GnrcIntvInd { get; set; }

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

    [Column("sch_event_name")]
    [StringLength(40)]
    public string? SchEventName { get; set; }

    [InverseProperty("EventTypNavigation")]
    public virtual ICollection<InstSchEventTyp> InstSchEventTyp { get; set; } = new List<InstSchEventTyp>();

    [InverseProperty("EventTypNavigation")]
    public virtual ICollection<IntvLibrary> IntvLibrary { get; set; } = new List<IntvLibrary>();

    [InverseProperty("FromEventTypNavigation")]
    public virtual ICollection<PtActualLink> PtActualLinkFromEventTypNavigation { get; set; } = new List<PtActualLink>();

    [InverseProperty("ToEventTypNavigation")]
    public virtual ICollection<PtActualLink> PtActualLinkToEventTypNavigation { get; set; } = new List<PtActualLink>();

    [InverseProperty("EventTypNavigation")]
    public virtual ICollection<PtTpIntv> PtTpIntv { get; set; } = new List<PtTpIntv>();

    [InverseProperty("EventTypNavigation")]
    public virtual ICollection<TpIntv> TpIntv { get; set; } = new List<TpIntv>();

    [InverseProperty("EventTypNavigation")]
    public virtual ICollection<TpIntvCat> TpIntvCat { get; set; } = new List<TpIntvCat>();

    [InverseProperty("EventTypNavigation")]
    public virtual ICollection<TxTframeIntvUse> TxTframeIntvUse { get; set; } = new List<TxTframeIntvUse>();
}
