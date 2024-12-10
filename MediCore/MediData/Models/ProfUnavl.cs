using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "UseridLink", "ProfUnavlId", "TransLogTstamp")]
[Table("prof_unavl")]
[Index("InstId", "UseridLink", "UnavlDate", Name = "nc1_prof_unavl")]
[Index("PtId", "PtVisitId", Name = "nc2_prof_unavl")]
[Index("UnavlInstId", "ProfUnavlFrom", Name = "nc3_prof_unavl")]
[Index("InstId", "UseridLink", "PtId", "PtVisitId", Name = "nc4_prof_unavl")]
[Index("UnavlHdrInstId", "UnavlHdrId", Name = "nc5_prof_unavl")]
[Index("InstId", "UseridLink", "ProfUnavlFrom", Name = "nc6_prof_unavl")]
public partial class ProfUnavl
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid_link")]
    [StringLength(255)]
    public string UseridLink { get; set; } = null!;

    [Key]
    [Column("prof_unavl_id")]
    public int ProfUnavlId { get; set; }

    [Column("unavl_typ")]
    public int? UnavlTyp { get; set; }

    [Column("prof_unavl_from", TypeName = "datetime")]
    public DateTime? ProfUnavlFrom { get; set; }

    [Column("prof_unavl_to", TypeName = "datetime")]
    public DateTime? ProfUnavlTo { get; set; }

    [Column("prof_unavl_dow")]
    public int? ProfUnavlDow { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("unavl_cmt")]
    [StringLength(200)]
    public string? UnavlCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

    [Column("unavl_date", TypeName = "datetime")]
    public DateTime? UnavlDate { get; set; }

    [Column("unavl_inst_id")]
    [StringLength(30)]
    public string? UnavlInstId { get; set; }

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

    [ForeignKey("ProfUnavlDow")]
    [InverseProperty("ProfUnavl")]
    public virtual UnavlDow? ProfUnavlDowNavigation { get; set; }

    [ForeignKey("UnavlTyp")]
    [InverseProperty("ProfUnavl")]
    public virtual UnavlTyp? UnavlTypNavigation { get; set; }

    [ForeignKey("InstId, UseridLink")]
    [InverseProperty("ProfUnavl")]
    public virtual Userid Userid { get; set; } = null!;
}
