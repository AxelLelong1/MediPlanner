using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MuErrorLogId", "CompliancePrdId")]
[Table("mu_error_log")]
public partial class MuErrorLog
{
    [Key]
    [Column("mu_error_log_id")]
    public int MuErrorLogId { get; set; }

    [Key]
    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

    [Column("error_description")]
    [StringLength(255)]
    public string? ErrorDescription { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
