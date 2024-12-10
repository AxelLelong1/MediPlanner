using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "ErxThreadItemId")]
[Table("erx_thread_item")]
[Index("PtId", "ErxThreadId", Name = "nc1_erx_thread_item")]
[Index("PtId", "ErxMsgTyp", "ErxEventId", Name = "nc2_erx_thread_item")]
public partial class ErxThreadItem
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("erx_thread_item_id")]
    public int ErxThreadItemId { get; set; }

    [Column("erx_thread_id")]
    public int ErxThreadId { get; set; }

    [Column("parent_erx_thread_id")]
    public int? ParentErxThreadId { get; set; }

    [Column("erx_msg_typ")]
    [StringLength(6)]
    public string ErxMsgTyp { get; set; } = null!;

    [Column("erx_event_id")]
    public int ErxEventId { get; set; }

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }
}
