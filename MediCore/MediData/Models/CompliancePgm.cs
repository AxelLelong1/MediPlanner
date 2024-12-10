using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("compliance_pgm")]
public partial class CompliancePgm
{
    [Key]
    [Column("compliance_pgm_id")]
    public int CompliancePgmId { get; set; }

    [Column("compliance_pgm")]
    [StringLength(30)]
    public string? CompliancePgm1 { get; set; }

    [Column("compliance_pgm_desc")]
    [StringLength(200)]
    public string? CompliancePgmDesc { get; set; }

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

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [InverseProperty("CompliancePgm")]
    public virtual ICollection<CompliancePrd> CompliancePrd { get; set; } = new List<CompliancePrd>();
}
