using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "VisitNoteRcptId", "PtVisitId", "VisitNoteId")]
[Table("visit_note_rcpt")]
public partial class VisitNoteRcpt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("visit_note_rcpt_id")]
    public int VisitNoteRcptId { get; set; }

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("visit_note_id")]
    public int VisitNoteId { get; set; }

    [Column("visit_note_revision_no")]
    public int VisitNoteRevisionNo { get; set; }

    public long ResourceSer { get; set; }

    [Column("corsp_mthd_cd")]
    [StringLength(1)]
    public string CorspMthdCd { get; set; } = null!;

    [Column("sent_tstamp", TypeName = "datetime")]
    public DateTime? SentTstamp { get; set; }

    [Column("sent_hdr_txt")]
    public string? SentHdrTxt { get; set; }

    [Column("sent_ftr_txt")]
    public string? SentFtrTxt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("fax_status")]
    [StringLength(1)]
    public string? FaxStatus { get; set; }

    [Column("fax_request_id")]
    [StringLength(255)]
    public string? FaxRequestId { get; set; }

    [Column("status_query_count")]
    public int? StatusQueryCount { get; set; }

    [Column("fax_tel")]
    [StringLength(64)]
    public string? FaxTel { get; set; }
}
