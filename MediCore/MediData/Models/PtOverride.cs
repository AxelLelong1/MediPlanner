using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtOverrideId")]
[Table("pt_override")]
public partial class PtOverride
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_override_id")]
    public int PtOverrideId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("pt_actual_id")]
    public int? PtActualId { get; set; }

    [Column("override_typ")]
    public int? OverrideTyp { get; set; }

    [Column("rsn_id")]
    public int? RsnId { get; set; }

    [Column("rsn_inst_id")]
    [StringLength(30)]
    public string? RsnInstId { get; set; }

    [Column("rsn_desc")]
    [StringLength(255)]
    public string? RsnDesc { get; set; }

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
