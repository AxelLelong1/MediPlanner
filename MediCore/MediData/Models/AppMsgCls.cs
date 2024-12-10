using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("app_msg_cls")]
public partial class AppMsgCls
{
    [Key]
    [Column("app_msg_cls_seq_no")]
    public int AppMsgClsSeqNo { get; set; }

    [Column("app_msg_cls_title")]
    [StringLength(100)]
    public string AppMsgClsTitle { get; set; } = null!;

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

    [InverseProperty("AppMsgClsSeqNoNavigation")]
    public virtual ICollection<AppMsg> AppMsg { get; set; } = new List<AppMsg>();
}
