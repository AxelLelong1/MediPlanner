using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MsgNo", "LangTyp")]
[Table("app_msg")]
public partial class AppMsg
{
    [Key]
    [Column("msg_no")]
    [StringLength(10)]
    public string MsgNo { get; set; } = null!;

    [Key]
    [Column("lang_typ")]
    public int LangTyp { get; set; }

    [Column("app_msg_fmt_seq_no")]
    public int AppMsgFmtSeqNo { get; set; }

    [Column("app_msg_cls_seq_no")]
    public int AppMsgClsSeqNo { get; set; }

    [Column("msg_txt_1")]
    [StringLength(255)]
    public string MsgTxt1 { get; set; } = null!;

    [Column("msg_txt_2")]
    [StringLength(255)]
    public string? MsgTxt2 { get; set; }

    [Column("msg_hlp_1")]
    [StringLength(255)]
    public string? MsgHlp1 { get; set; }

    [Column("msg_hlp_2")]
    [StringLength(255)]
    public string? MsgHlp2 { get; set; }

    [Column("msg_hlp_3")]
    [StringLength(255)]
    public string? MsgHlp3 { get; set; }

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

    [ForeignKey("AppMsgClsSeqNo")]
    [InverseProperty("AppMsg")]
    public virtual AppMsgCls AppMsgClsSeqNoNavigation { get; set; } = null!;

    [ForeignKey("AppMsgFmtSeqNo")]
    [InverseProperty("AppMsg")]
    public virtual AppMsgFmt AppMsgFmtSeqNoNavigation { get; set; } = null!;
}
