using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CompliancePeriodId", "ComplianceItem", "StkhId")]
[Table("compliance_prd_binary_measure")]
public partial class CompliancePrdBinaryMeasure
{
    [Key]
    public int CompliancePeriodId { get; set; }

    [Key]
    [StringLength(60)]
    public string ComplianceItem { get; set; } = null!;

    [StringLength(1)]
    public string MeasureMet { get; set; } = null!;

    public int ComplianceItemId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;
}
