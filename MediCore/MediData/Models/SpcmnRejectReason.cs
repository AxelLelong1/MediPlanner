using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("spcmn_reject_reason")]
public partial class SpcmnRejectReason
{
    [Key]
    [Column("spcmn_reject_reason_id")]
    public int SpcmnRejectReasonId { get; set; }

    [Column("spcmn_reject_reason_cd")]
    [StringLength(5)]
    public string SpcmnRejectReasonCd { get; set; } = null!;

    [Column("spcmn_reject_reason_desc")]
    [StringLength(30)]
    public string? SpcmnRejectReasonDesc { get; set; }

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

    [InverseProperty("SpcmnRejectReason")]
    public virtual ICollection<TestSpcmn> TestSpcmn { get; set; } = new List<TestSpcmn>();
}
