using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("allergy_severity")]
public partial class AllergySeverity
{
    [Key]
    [Column("severity_id")]
    public int SeverityId { get; set; }

    [Column("severity_cd")]
    [StringLength(5)]
    public string SeverityCd { get; set; } = null!;

    [Column("severity_desc")]
    [StringLength(40)]
    public string SeverityDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("Severity")]
    public virtual ICollection<PtAllergy> PtAllergy { get; set; } = new List<PtAllergy>();
}
