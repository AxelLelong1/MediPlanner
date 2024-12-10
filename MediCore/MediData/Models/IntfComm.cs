using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_comm")]
public partial class IntfComm
{
    [Key]
    [Column("intf_comm_id")]
    [StringLength(10)]
    public string IntfCommId { get; set; } = null!;

    [Column("comm_name")]
    [StringLength(30)]
    public string CommName { get; set; } = null!;

    [Column("comm_desc")]
    [StringLength(255)]
    public string? CommDesc { get; set; }

    [Column("protocol")]
    [StringLength(1)]
    public string Protocol { get; set; } = null!;

    [Column("msg_len_encode")]
    [StringLength(1)]
    public string? MsgLenEncode { get; set; }

    [Column("rmot_port")]
    [StringLength(6)]
    public string? RmotPort { get; set; }

    [Column("rmot_address")]
    [StringLength(20)]
    public string? RmotAddress { get; set; }

    [Column("login_userid")]
    [StringLength(255)]
    public string? LoginUserid { get; set; }

    [Column("login_pwd")]
    [StringLength(20)]
    public string? LoginPwd { get; set; }

    [Column("dbms")]
    [StringLength(4)]
    public string? Dbms { get; set; }

    [Column("svr_name")]
    [StringLength(30)]
    public string? SvrName { get; set; }

    [Column("db_name")]
    [StringLength(30)]
    public string? DbName { get; set; }

    [Column("tcpip_prcs_path")]
    [StringLength(80)]
    public string? TcpipPrcsPath { get; set; }

    [Column("tcpip_bkup_path")]
    [StringLength(80)]
    public string? TcpipBkupPath { get; set; }

    [Column("tcpip_err_path")]
    [StringLength(80)]
    public string? TcpipErrPath { get; set; }

    [Column("tcpip_bkup_days")]
    public int? TcpipBkupDays { get; set; }

    [Column("tcpip_err_days")]
    public int? TcpipErrDays { get; set; }

    [Column("tcpip_debug_ind")]
    [StringLength(1)]
    public string? TcpipDebugInd { get; set; }

    [Column("msg_resend_min")]
    public int? MsgResendMin { get; set; }

    [Column("direction_ind")]
    [StringLength(1)]
    public string DirectionInd { get; set; } = null!;

    [Column("imp_compl_ind")]
    [StringLength(1)]
    public string? ImpComplInd { get; set; }

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

    [Column("tcpip_log_path")]
    [StringLength(80)]
    public string? TcpipLogPath { get; set; }

    [Column("intf_engine_id")]
    [StringLength(10)]
    public string? IntfEngineId { get; set; }

    [Column("seq_no_protocol_ind")]
    [StringLength(1)]
    public string? SeqNoProtocolInd { get; set; }

    [Column("seq_no_state_cd")]
    [StringLength(1)]
    public string? SeqNoStateCd { get; set; }

    [Column("last_rcv_seq_no")]
    public int? LastRcvSeqNo { get; set; }

    [Column("seq_no_protocol_seq")]
    public int? SeqNoProtocolSeq { get; set; }

    [Column("resync_link_ind")]
    [StringLength(1)]
    public string? ResyncLinkInd { get; set; }

    [Column("frozen_link_ind")]
    [StringLength(1)]
    public string? FrozenLinkInd { get; set; }

    [Column("resend_msg_ind")]
    [StringLength(1)]
    public string? ResendMsgInd { get; set; }

    [Column("link_down_ok_ind")]
    [StringLength(1)]
    public string? LinkDownOkInd { get; set; }

    [Column("email_resend_count")]
    public int? EmailResendCount { get; set; }

    [Column("socket_down_resend_min")]
    public int? SocketDownResendMin { get; set; }

    [Column("tcpip_log_days")]
    public int? TcpipLogDays { get; set; }

    [Column("rmot_ack_port")]
    [StringLength(6)]
    public string? RmotAckPort { get; set; }

    [Column("ack_intf_comm_id")]
    [StringLength(10)]
    public string? AckIntfCommId { get; set; }

    [Column("ack_active_ind")]
    [StringLength(1)]
    public string? AckActiveInd { get; set; }

    [Column("purge_intf_engine_id")]
    [StringLength(10)]
    public string? PurgeIntfEngineId { get; set; }

    [Column("tcpip_idle_disconnect_timeout")]
    public int? TcpipIdleDisconnectTimeout { get; set; }

    [Column("cust_name_id")]
    [StringLength(20)]
    public string? CustNameId { get; set; }

    [Column("cust_ind")]
    [StringLength(1)]
    public string? CustInd { get; set; }

    [Column("drop_connection_typ")]
    [StringLength(1)]
    public string? DropConnectionTyp { get; set; }

    [Column("socket_security_ind")]
    [StringLength(1)]
    public string? SocketSecurityInd { get; set; }

    [ForeignKey("IntfEngineId")]
    [InverseProperty("IntfComm")]
    public virtual IntfEngine? IntfEngine { get; set; }
}
