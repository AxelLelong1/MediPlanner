using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_err_log")]
[Index("GeneratedTstamp", Name = "nc1_erx_err_log")]
[Index("EdiOutId", Name = "nc2_erx_err_log")]
public partial class ErxErrLog
{
    [Key]
    [Column("erx_err_log_id")]
    public int ErxErrLogId { get; set; }

    [Column("external_err_cd")]
    [StringLength(6)]
    public string? ExternalErrCd { get; set; }

    [Column("internal_err_cd")]
    [StringLength(6)]
    public string? InternalErrCd { get; set; }

    [Column("err_desc")]
    [StringLength(255)]
    public string? ErrDesc { get; set; }

    [Column("tech_err_desc")]
    [StringLength(1500)]
    public string? TechErrDesc { get; set; }

    [Column("edi_out_id")]
    public int? EdiOutId { get; set; }

    [Column("rcvd_from")]
    [StringLength(35)]
    public string? RcvdFrom { get; set; }

    [Column("generated_tstamp", TypeName = "datetime")]
    public DateTime? GeneratedTstamp { get; set; }

    [Column("ack_ind")]
    [StringLength(1)]
    public string? AckInd { get; set; }

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
}
