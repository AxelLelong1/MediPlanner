using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("clinical_notifctn_usr_grp")]
[Index("ClinicalNotificationId", Name = "nc1_clinical_notifctn_usr_grp")]
public partial class ClinicalNotifctnUsrGrp
{
    [Key]
    [Column("clinical_notifctn_usr_grp_id")]
    public int ClinicalNotifctnUsrGrpId { get; set; }

    [Column("clinical_notification_id")]
    public int ClinicalNotificationId { get; set; }

    [Column("osp_user_group_id")]
    [StringLength(32)]
    public string OspUserGroupId { get; set; } = null!;

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
}
