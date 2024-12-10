using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("user_msg")]
public partial class UserMsg
{
    [Key]
    [Column("msg_id")]
    public int MsgId { get; set; }

    [Column("msg_creator_userid")]
    [StringLength(255)]
    public string? MsgCreatorUserid { get; set; }

    [Column("msg_creator_inst_id")]
    [StringLength(30)]
    public string? MsgCreatorInstId { get; set; }

    [Column("msg_topic")]
    [StringLength(100)]
    public string? MsgTopic { get; set; }

    [Column("msg_txt")]
    public string? MsgTxt { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("rcpnt_discipline_typ")]
    public int? RcpntDisciplineTyp { get; set; }

    [Column("rcpnt_inst_id")]
    [StringLength(30)]
    public string? RcpntInstId { get; set; }

    [Column("inactivate_date", TypeName = "datetime")]
    public DateTime? InactivateDate { get; set; }
}
