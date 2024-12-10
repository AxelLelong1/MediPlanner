using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("app_msg_fmt")]
public partial class AppMsgFmt
{
    [Key]
    [Column("app_msg_fmt_seq_no")]
    public int AppMsgFmtSeqNo { get; set; }

    [Column("msg_ser_cd")]
    [StringLength(1)]
    public string MsgSerCd { get; set; } = null!;

    [Column("msg_ser_cd_levl")]
    public int MsgSerCdLevl { get; set; }

    [Column("msg_icon_name")]
    [StringLength(20)]
    public string MsgIconName { get; set; } = null!;

    [Column("msg_btn1_txt")]
    [StringLength(10)]
    public string MsgBtn1Txt { get; set; } = null!;

    [Column("msg_btn2_txt")]
    [StringLength(10)]
    public string? MsgBtn2Txt { get; set; }

    [Column("msg_btn3_txt")]
    [StringLength(10)]
    public string? MsgBtn3Txt { get; set; }

    [Column("msg_dflt_btn")]
    public int? MsgDfltBtn { get; set; }

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

    [Column("show_msg_no")]
    [StringLength(1)]
    public string? ShowMsgNo { get; set; }

    [InverseProperty("AppMsgFmtSeqNoNavigation")]
    public virtual ICollection<AppMsg> AppMsg { get; set; } = new List<AppMsg>();
}
