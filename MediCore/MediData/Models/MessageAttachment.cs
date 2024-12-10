using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("message_attachment")]
public partial class MessageAttachment
{
    [Key]
    [Column("message_attachment_id")]
    public int MessageAttachmentId { get; set; }

    [Column("message_id")]
    public int? MessageId { get; set; }

    [Column("message_attachment_file_name")]
    [StringLength(64)]
    public string? MessageAttachmentFileName { get; set; }

    [Column("message_attachment_content_type")]
    [StringLength(256)]
    public string? MessageAttachmentContentType { get; set; }

    [Column("message_attachment_length")]
    public long? MessageAttachmentLength { get; set; }

    [Column("doc_file_loc")]
    [StringLength(255)]
    public string? DocFileLoc { get; set; }

    [Column("img_dcmnt_id")]
    [StringLength(14)]
    public string? ImgDcmntId { get; set; }

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

    [ForeignKey("MessageId")]
    [InverseProperty("MessageAttachment")]
    public virtual Message? Message { get; set; }
}
