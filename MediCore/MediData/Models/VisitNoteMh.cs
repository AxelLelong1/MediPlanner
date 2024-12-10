using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "VisitNoteId", "RevisionNo")]
[Table("visit_note_mh")]
public partial class VisitNoteMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("visit_note_id")]
    public int VisitNoteId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("note_tstamp", TypeName = "datetime")]
    public DateTime? NoteTstamp { get; set; }

    [Column("visit_note_txt")]
    public string? VisitNoteTxt { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string ApprFlag { get; set; } = null!;

    [Column("dictated_flag")]
    [StringLength(1)]
    public string DictatedFlag { get; set; } = null!;

    [Column("override_userid")]
    [StringLength(255)]
    public string? OverrideUserid { get; set; }

    [Column("override_txt")]
    [StringLength(200)]
    public string? OverrideTxt { get; set; }

    [Column("override_inst_id")]
    [StringLength(30)]
    public string? OverrideInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("pt_focus_id")]
    public int? PtFocusId { get; set; }

    [Column("pt_eval_id")]
    public int? PtEvalId { get; set; }

    [Column("pt_event_id")]
    public int? PtEventId { get; set; }

    [Column("note_level")]
    public int? NoteLevel { get; set; }

    [Column("note_typ")]
    public int? NoteTyp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("dcmmt_id")]
    [StringLength(20)]
    public string? DcmmtId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("priv_ind")]
    [StringLength(1)]
    public string? PrivInd { get; set; }

    [Column("pre_appr_ind")]
    [StringLength(1)]
    public string? PreApprInd { get; set; }

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

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

    [Column("visit_note_begin_txt")]
    [StringLength(255)]
    public string? VisitNoteBeginTxt { get; set; }

    [Column("correction_ind")]
    [StringLength(1)]
    public string? CorrectionInd { get; set; }

    [Column("generated_ind")]
    [StringLength(1)]
    public string? GeneratedInd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("completed_ind")]
    [StringLength(1)]
    public string? CompletedInd { get; set; }

    [Column("rem_attach_ind")]
    [StringLength(1)]
    public string? RemAttachInd { get; set; }

    [Column("dcmnt_err_ind")]
    [StringLength(1)]
    public string? DcmntErrInd { get; set; }

    [Column("appr_stkh_id")]
    [StringLength(20)]
    public string? ApprStkhId { get; set; }

    [Column("intf_created_ind")]
    [StringLength(1)]
    public string? IntfCreatedInd { get; set; }

    [Column("bill_acct_id")]
    public int? BillAcctId { get; set; }

    [Column("review_req_ind")]
    [StringLength(1)]
    public string? ReviewReqInd { get; set; }

    [Column("doc_file_typ")]
    public int? DocFileTyp { get; set; }

    [Column("doc_file_loc")]
    [StringLength(255)]
    public string? DocFileLoc { get; set; }

    [Column("supervisor_stkh_id")]
    [StringLength(20)]
    public string? SupervisorStkhId { get; set; }

    [Column("signed_stkh_id")]
    [StringLength(20)]
    public string? SignedStkhId { get; set; }

    [Column("signed_tstamp", TypeName = "datetime")]
    public DateTime? SignedTstamp { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("document_ser")]
    public int? DocumentSer { get; set; }

    [Column("printed_ind")]
    [StringLength(1)]
    public string? PrintedInd { get; set; }

    [Column("dcmnt_id_long")]
    [StringLength(30)]
    public string? DcmntIdLong { get; set; }

    [Column("lt_archive_ind")]
    [StringLength(1)]
    public string? LtArchiveInd { get; set; }

    [Column("account_billing_code_ser")]
    public long? AccountBillingCodeSer { get; set; }

    [Column("template_name")]
    [StringLength(50)]
    public string? TemplateName { get; set; }

    [Column("external_system_name")]
    [StringLength(50)]
    public string? ExternalSystemName { get; set; }

    [Column("external_document_link")]
    [StringLength(256)]
    public string? ExternalDocumentLink { get; set; }

    [Column("revised_ind")]
    [StringLength(1)]
    public string? RevisedInd { get; set; }

    [Column("system_gen_ind")]
    [StringLength(1)]
    public string? SystemGenInd { get; set; }

    [Column("pt_provided_ind")]
    [StringLength(1)]
    public string? PtProvidedInd { get; set; }

    [Column("pt_provided_name")]
    [StringLength(255)]
    public string? PtProvidedName { get; set; }
}
