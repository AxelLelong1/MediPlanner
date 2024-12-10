using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "LocId", "LocUnavlId")]
[Table("loc_unavl")]
[Index("InstId", "LocId", "UnavlDate", Name = "nc1_loc_unavl")]
[Index("PtId", "PtVisitId", "InstId", "LocId", Name = "nc2_loc_unavl")]
[Index("UnavlHdrInstId", "UnavlHdrId", Name = "nc3_loc_unavl")]
[Index("UnavlDate", "PtId", "InstId", Name = "nc4_loc_unavl")]
public partial class LocUnavl
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("loc_id")]
    public int LocId { get; set; }

    [Key]
    [Column("loc_unavl_id")]
    public int LocUnavlId { get; set; }

    [Column("unavl_from", TypeName = "datetime")]
    public DateTime UnavlFrom { get; set; }

    [Column("unavl_to", TypeName = "datetime")]
    public DateTime UnavlTo { get; set; }

    [Column("unavl_date", TypeName = "datetime")]
    public DateTime UnavlDate { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("unavl_cmt")]
    [StringLength(200)]
    public string? UnavlCmt { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

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

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("unavl_hdr_inst_id")]
    [StringLength(30)]
    public string? UnavlHdrInstId { get; set; }

    [Column("unavl_hdr_id")]
    public int? UnavlHdrId { get; set; }

    [Column("partial_usage_qty")]
    public int? PartialUsageQty { get; set; }

    [Column("unavl_template_id")]
    public int? UnavlTemplateId { get; set; }
}
