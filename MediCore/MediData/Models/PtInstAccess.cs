using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "InstId")]
[Table("pt_inst_access")]
[Index("InstId", "FirstVisitDate", Name = "nc1_pt_inst_access")]
[Index("PtId", Name = "nc2_pt_inst_access")]
public partial class PtInstAccess
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

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

    [Column("active_visit_ind")]
    [StringLength(1)]
    public string? ActiveVisitInd { get; set; }

    [Column("first_visit_date", TypeName = "datetime")]
    public DateTime? FirstVisitDate { get; set; }

    [Column("last_visit_date", TypeName = "datetime")]
    public DateTime? LastVisitDate { get; set; }

    [Column("restrict_access_ind")]
    [StringLength(1)]
    public string? RestrictAccessInd { get; set; }
}
