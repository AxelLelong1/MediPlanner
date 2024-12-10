using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ErxOutboundStatusVerifyErrorId", "RevisionNo")]
[Table("erx_outbound_status_verify_error_mh")]
public partial class ErxOutboundStatusVerifyErrorMh
{
    [Key]
    [Column("erx_outbound_status_verify_error_id")]
    public int ErxOutboundStatusVerifyErrorId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("message_type")]
    [StringLength(8)]
    public string MessageType { get; set; } = null!;

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("pharm_id")]
    [StringLength(7)]
    public string PharmId { get; set; } = null!;

    [Column("relates_to_message_id")]
    [StringLength(35)]
    public string RelatesToMessageId { get; set; } = null!;

    [Column("status_verify_error_cd")]
    [StringLength(3)]
    public string StatusVerifyErrorCd { get; set; } = null!;

    [Column("status_verify_error_desc")]
    [StringLength(70)]
    public string? StatusVerifyErrorDesc { get; set; }

    [Column("sent_ind")]
    [StringLength(1)]
    public string SentInd { get; set; } = null!;

    [Column("sent_dt", TypeName = "datetime")]
    public DateTime? SentDt { get; set; }

    [Column("rcvd_ind")]
    [StringLength(1)]
    public string? RcvdInd { get; set; }

    [Column("rcvd_dt", TypeName = "datetime")]
    public DateTime? RcvdDt { get; set; }

    [Column("resp_to_message_type")]
    [StringLength(8)]
    public string? RespToMessageType { get; set; }

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

    [Column("spi")]
    [StringLength(35)]
    public string Spi { get; set; } = null!;

    [Column("prescriber_order_number")]
    [StringLength(15)]
    public string? PrescriberOrderNumber { get; set; }
}
