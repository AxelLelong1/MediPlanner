using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TrfFnctn", "TrfMsgTstamp", "TrfSeqNo")]
[Table("trf_msg_log")]
public partial class TrfMsgLog
{
    [Key]
    [Column("trf_fnctn")]
    [StringLength(30)]
    public string TrfFnctn { get; set; } = null!;

    [Key]
    [Column("trf_msg_tstamp", TypeName = "datetime")]
    public DateTime TrfMsgTstamp { get; set; }

    [Key]
    [Column("trf_seq_no")]
    public int TrfSeqNo { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("msg_typ")]
    [StringLength(1)]
    public string? MsgTyp { get; set; }

    [Column("command_typ")]
    [StringLength(20)]
    public string? CommandTyp { get; set; }

    [Column("tbl_name")]
    [StringLength(30)]
    public string? TblName { get; set; }

    [Column("return_cd")]
    public int? ReturnCd { get; set; }

    [Column("msg_text")]
    [StringLength(200)]
    public string? MsgText { get; set; }

    [Column("detail_msg_text")]
    public string? DetailMsgText { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;
}
