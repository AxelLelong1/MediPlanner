using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtCommLogId")]
[Table("pt_comm_log")]
public partial class PtCommLog
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_comm_log_id")]
    public int PtCommLogId { get; set; }

    [Column("pt_comm_log_typ")]
    public int PtCommLogTyp { get; set; }

    [Column("pt_actual_id")]
    public int? PtActualId { get; set; }

    [Column("visit_note_id")]
    public int? VisitNoteId { get; set; }

    [Column("pt_comm_log_date", TypeName = "datetime")]
    public DateTime? PtCommLogDate { get; set; }

    [Column("pt_comm_log_cmt")]
    [StringLength(255)]
    public string? PtCommLogCmt { get; set; }

    [Column("delivery_method_typ")]
    public int DeliveryMethodTyp { get; set; }

    [Column("destination")]
    [StringLength(255)]
    public string? Destination { get; set; }

    [Column("content_desc")]
    public string? ContentDesc { get; set; }

    [Column("status_cd")]
    [StringLength(1)]
    public string? StatusCd { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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

    [Column("pt_prefer_value_typ")]
    public int? PtPreferValueTyp { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtCommLog")]
    public virtual Pt Pt { get; set; } = null!;
}
