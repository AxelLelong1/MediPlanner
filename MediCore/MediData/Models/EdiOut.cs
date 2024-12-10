using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("edi_out")]
[Index("ProcessedInd", Name = "nc1_edi_out")]
[Index("EventId", "PtId", Name = "nc2_edi_out")]
[Index("PtId", "MessageUid", Name = "nc3_edi_out")]
public partial class EdiOut
{
    [Key]
    [Column("edi_out_id")]
    public int EdiOutId { get; set; }

    [Column("msg")]
    [StringLength(8)]
    public string Msg { get; set; } = null!;

    [Column("msg_txt")]
    public string? MsgTxt { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("event_id")]
    public int? EventId { get; set; }

    [Column("event_id_alt")]
    public int? EventIdAlt { get; set; }

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("pharm_id")]
    [StringLength(10)]
    public string? PharmId { get; set; }

    [Column("processed_ind")]
    [StringLength(1)]
    public string? ProcessedInd { get; set; }

    [Column("sent_dt", TypeName = "datetime")]
    public DateTime? SentDt { get; set; }

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

    [Column("ref_edi_out_id")]
    public int? RefEdiOutId { get; set; }

    [Column("message_uid")]
    [StringLength(32)]
    public string? MessageUid { get; set; }

    [Column("req_two_factor_auth")]
    [StringLength(1)]
    public string? ReqTwoFactorAuth { get; set; }
}
