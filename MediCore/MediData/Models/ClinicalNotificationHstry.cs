using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("clinical_notification_hstry")]
[Index("ClinicalNotificationId", Name = "nc1_clinical_notification_hstry")]
public partial class ClinicalNotificationHstry
{
    [Key]
    [Column("clinical_notification_hstry_id")]
    public int ClinicalNotificationHstryId { get; set; }

    [Column("clinical_notification_id")]
    public int ClinicalNotificationId { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
