using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DictationQueueId", "RevisionNo")]
[Table("dictation_queue_mh")]
public partial class DictationQueueMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("dictation_queue_id")]
    public int DictationQueueId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("dictation_typ")]
    public int DictationTyp { get; set; }

    [Column("pt_actual_id")]
    public int? PtActualId { get; set; }

    [Column("pt_child_actual_id")]
    public int? PtChildActualId { get; set; }

    [Column("actual_desc")]
    [StringLength(255)]
    public string? ActualDesc { get; set; }

    [Column("dictation_file_id")]
    [StringLength(14)]
    public string? DictationFileId { get; set; }

    [Column("dictated_by_userid")]
    [StringLength(255)]
    public string? DictatedByUserid { get; set; }

    [Column("dictated_by_user_inst_id")]
    [StringLength(30)]
    public string? DictatedByUserInstId { get; set; }

    [Column("dictation_complete_ind")]
    [StringLength(1)]
    public string? DictationCompleteInd { get; set; }

    [Column("transcription_userid")]
    [StringLength(255)]
    public string? TranscriptionUserid { get; set; }

    [Column("transcription_user_inst_id")]
    [StringLength(30)]
    public string? TranscriptionUserInstId { get; set; }

    [Column("transcription_tstamp", TypeName = "datetime")]
    public DateTime? TranscriptionTstamp { get; set; }

    [Column("transcription_txt")]
    public string? TranscriptionTxt { get; set; }

    [Column("review_required_ind")]
    [StringLength(1)]
    public string? ReviewRequiredInd { get; set; }

    [Column("transcription_complete_ind")]
    [StringLength(1)]
    public string? TranscriptionCompleteInd { get; set; }

    [Column("transcription_char_count")]
    public int? TranscriptionCharCount { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("audio_del_ind")]
    [StringLength(1)]
    public string? AudioDelInd { get; set; }

    [ForeignKey("PtId, DictationQueueId")]
    [InverseProperty("DictationQueueMh")]
    public virtual DictationQueue DictationQueue { get; set; } = null!;
}
