using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactVisitNotes
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("visit_note_id")]
    public int VisitNoteId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VisitNoteDateTime { get; set; }

    [StringLength(3000)]
    public string? VisitNoteText { get; set; }

    [StringLength(1)]
    public string ApprovedFlag { get; set; } = null!;

    [StringLength(1)]
    public string DictatedFlag { get; set; } = null!;

    [StringLength(255)]
    public string? OverrideUserId { get; set; }

    [StringLength(30)]
    public string? OverrideInstId { get; set; }

    [StringLength(200)]
    public string? OverrideTxt { get; set; }

    [Column("DimDateID_VisitNote")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdVisitNote { get; set; } = null!;

    [Column("DimDateID_Signed")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdSigned { get; set; } = null!;

    [Column("DimDateID_Approved")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdApproved { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    public int? VisitNoteType { get; set; }

    [StringLength(1)]
    public string? ValidIndicator { get; set; }

    [StringLength(1)]
    public string? PrivateIndicator { get; set; }

    [StringLength(40)]
    public string? DisciplineType { get; set; }

    public int? ProfType { get; set; }

    [Column("creator_stkh_id")]
    [StringLength(20)]
    public string? CreatorStkhId { get; set; }

    [Column("author_stkh_id")]
    [StringLength(20)]
    public string? AuthorStkhId { get; set; }

    [Column("author_org_stkh_id")]
    [StringLength(20)]
    public string? AuthorOrgStkhId { get; set; }

    [Column("cert_stkh_id")]
    [StringLength(20)]
    public string? CertStkhId { get; set; }

    [Column("img_dcmnt_id")]
    [StringLength(14)]
    public string? ImgDcmntId { get; set; }

    [StringLength(1)]
    public string? GeneratedIndicator { get; set; }

    [StringLength(1)]
    public string? CompletedIndicator { get; set; }

    [StringLength(1)]
    public string? RemAttachedIndicator { get; set; }

    [StringLength(20)]
    public string? ApprovedByStkhId { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? BillAccountId { get; set; }

    [StringLength(20)]
    public string? SupervisedByStkhId { get; set; }

    [StringLength(20)]
    public string? SignedByStkhId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public int? DocumentSer { get; set; }

    [StringLength(50)]
    public string? TemplateName { get; set; }
}
