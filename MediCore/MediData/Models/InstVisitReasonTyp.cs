using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "VisitReasonId")]
[Table("inst_visit_reason_typ")]
public partial class InstVisitReasonTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("visit_reason_id")]
    public int VisitReasonId { get; set; }

    [Column("visit_reason_typ")]
    public int VisitReasonTyp { get; set; }

    [Column("visit_reason_desc")]
    [StringLength(40)]
    public string VisitReasonDesc { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("mapping_cd")]
    [StringLength(30)]
    public string? MappingCd { get; set; }

    [InverseProperty("InstVisitReasonTyp")]
    public virtual ICollection<VisitReasonPnTemplate> VisitReasonPnTemplate { get; set; } = new List<VisitReasonPnTemplate>();
}
