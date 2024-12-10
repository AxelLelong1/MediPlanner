using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("print_audit_rec")]
public partial class PrintAuditRec
{
    [Key]
    [Column("audit_seq_no")]
    public int AuditSeqNo { get; set; }

    [Column("print_datetime", TypeName = "datetime")]
    public DateTime? PrintDatetime { get; set; }

    [Column("user_inst_id")]
    [StringLength(30)]
    public string? UserInstId { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string? Userid { get; set; }

    [Column("audit_desc")]
    [StringLength(255)]
    public string? AuditDesc { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
