using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_ol_prcs_stat")]
public partial class IntfOlPrcsStat
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("msg_cnt")]
    public int? MsgCnt { get; set; }

    [Column("err_msg_cnt")]
    public int? ErrMsgCnt { get; set; }

    [Column("scss_msg_cnt")]
    public int? ScssMsgCnt { get; set; }

    [Column("wrng_msg_cnt")]
    public int? WrngMsgCnt { get; set; }

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("filter_cnt")]
    public int? FilterCnt { get; set; }

    [Column("last_prcs_tstamp", TypeName = "datetime")]
    public DateTime? LastPrcsTstamp { get; set; }

    [Column("last_rcv_sent_tstamp", TypeName = "datetime")]
    public DateTime? LastRcvSentTstamp { get; set; }
}
