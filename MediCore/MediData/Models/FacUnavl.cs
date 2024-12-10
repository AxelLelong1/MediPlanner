using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "UnavlId", "TransLogTstamp")]
[Table("fac_unavl")]
[Index("PtId", "PtVisitId", Name = "nc1_fac_unavl")]
public partial class FacUnavl
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("unavl_id")]
    public int UnavlId { get; set; }

    [Column("fac_id")]
    public int? FacId { get; set; }

    [Column("unavl_typ")]
    public int UnavlTyp { get; set; }

    [Column("unavl_dow")]
    public int? UnavlDow { get; set; }

    [Column("unavl_from", TypeName = "datetime")]
    public DateTime UnavlFrom { get; set; }

    [Column("unavl_to", TypeName = "datetime")]
    public DateTime UnavlTo { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("room_typ")]
    public int? RoomTyp { get; set; }

    [Column("unavl_cmt")]
    [StringLength(200)]
    public string? UnavlCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

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
}
