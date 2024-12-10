using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_ol_stat")]
public partial class IntfOlStat
{
    [Key]
    [Column("intf_comm_id")]
    [StringLength(10)]
    public string IntfCommId { get; set; } = null!;

    [Column("app_inbnd_msg_cnt")]
    public int? AppInbndMsgCnt { get; set; }

    [Column("app_inbnd_err_cnt")]
    public int? AppInbndErrCnt { get; set; }

    [Column("app_outbnd_msg_cnt")]
    public int? AppOutbndMsgCnt { get; set; }

    [Column("app_outbnd_err_cnt")]
    public int? AppOutbndErrCnt { get; set; }

    [Column("app_inbnd_cnct")]
    [StringLength(1)]
    public string? AppInbndCnct { get; set; }

    [Column("app_outbnd_cnct")]
    [StringLength(1)]
    public string? AppOutbndCnct { get; set; }

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

    [Column("ack_connected")]
    [StringLength(1)]
    public string? AckConnected { get; set; }
}
