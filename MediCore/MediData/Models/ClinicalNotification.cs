using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("clinical_notification")]
public partial class ClinicalNotification
{
    [Key]
    [Column("clinical_notification_id")]
    public int ClinicalNotificationId { get; set; }

    [Column("clinical_notification_name")]
    [StringLength(40)]
    public string ClinicalNotificationName { get; set; } = null!;

    [Column("clinical_notification_msg")]
    public string ClinicalNotificationMsg { get; set; } = null!;

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

    [Column("max_freq")]
    public int? MaxFreq { get; set; }

    [Column("max_freq_unit")]
    [StringLength(1)]
    public string? MaxFreqUnit { get; set; }

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

    [Column("notification_citation")]
    public string? NotificationCitation { get; set; }

    [Column("notification_developer")]
    public string? NotificationDeveloper { get; set; }

    [Column("notification_source")]
    public string? NotificationSource { get; set; }

    [Column("notification_release")]
    public string? NotificationRelease { get; set; }

    [Column("notification_url")]
    public string? NotificationUrl { get; set; }

    [InverseProperty("ClinicalNotification")]
    public virtual ICollection<PtClinicalNotificationCriteria> PtClinicalNotificationCriteria { get; set; } = new List<PtClinicalNotificationCriteria>();
}
