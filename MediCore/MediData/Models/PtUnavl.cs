using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtUnavlId")]
[Table("pt_unavl")]
[Index("PtId", "UnavlDate", Name = "nc1_pt_unavl")]
[Index("PtId", "PtVisitId", Name = "nc2_pt_unavl")]
[Index("UnavlHdrInstId", "UnavlHdrId", Name = "nc3_pt_unavl")]
[Index("PtUnavlFrom", Name = "nc4_pt_unavl")]
[Index("UnavlHdrInstId", "PtId", "PtVisitId", "UnavlHdrId", Name = "nc5_pt_unavl")]
public partial class PtUnavl
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_unavl_id")]
    public int PtUnavlId { get; set; }

    [Column("unavl_typ")]
    public int UnavlTyp { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("pt_unavl_dow")]
    public int? PtUnavlDow { get; set; }

    [Column("pt_unavl_from", TypeName = "datetime")]
    public DateTime PtUnavlFrom { get; set; }

    [Column("pt_unavl_to", TypeName = "datetime")]
    public DateTime PtUnavlTo { get; set; }

    [Column("unavl_cmt")]
    [StringLength(200)]
    public string? UnavlCmt { get; set; }

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

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

    [Column("unavl_date", TypeName = "datetime")]
    public DateTime? UnavlDate { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("unavl_hdr_inst_id")]
    [StringLength(30)]
    public string? UnavlHdrInstId { get; set; }

    [Column("unavl_hdr_id")]
    public int? UnavlHdrId { get; set; }

    [ForeignKey("PtUnavlDow")]
    [InverseProperty("PtUnavl")]
    public virtual UnavlDow? PtUnavlDowNavigation { get; set; }

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("PtUnavl")]
    public virtual PtVisit? PtVisit { get; set; }
}
