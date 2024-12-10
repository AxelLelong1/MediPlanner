using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InstSchEventTyp1")]
[Table("inst_sch_event_typ")]
public partial class InstSchEventTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("inst_sch_event_typ")]
    public int InstSchEventTyp1 { get; set; }

    [Column("inst_sch_event_desc")]
    [StringLength(40)]
    public string InstSchEventDesc { get; set; } = null!;

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("EventTyp")]
    [InverseProperty("InstSchEventTyp")]
    public virtual EventTyp EventTypNavigation { get; set; } = null!;
}
