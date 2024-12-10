using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtClinicalNotificationCriteriaId", "PtId")]
[Table("pt_clinical_notification_criteria")]
public partial class PtClinicalNotificationCriteria
{
    [Key]
    [Column("pt_clinical_notification_criteria_id")]
    public int PtClinicalNotificationCriteriaId { get; set; }

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_clinical_notification_id")]
    public int PtClinicalNotificationId { get; set; }

    [Column("clinical_notification_id")]
    public int ClinicalNotificationId { get; set; }

    [Column("query_id")]
    public int QueryId { get; set; }

    [Column("criteria_id")]
    public int CriteriaId { get; set; }

    [Column("criteria_type")]
    public int? CriteriaType { get; set; }

    [Column("value1")]
    [StringLength(255)]
    public string? Value1 { get; set; }

    [Column("value2")]
    [StringLength(255)]
    public string? Value2 { get; set; }

    [Column("value3")]
    [StringLength(255)]
    public string? Value3 { get; set; }

    [Column("value4")]
    [StringLength(255)]
    public string? Value4 { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

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

    [ForeignKey("ClinicalNotificationId")]
    [InverseProperty("PtClinicalNotificationCriteria")]
    public virtual ClinicalNotification ClinicalNotification { get; set; } = null!;

    [ForeignKey("CriteriaId")]
    [InverseProperty("PtClinicalNotificationCriteria")]
    public virtual PtListQueryCriteria Criteria { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtClinicalNotificationCriteria")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("QueryId")]
    [InverseProperty("PtClinicalNotificationCriteria")]
    public virtual PtListQuery Query { get; set; } = null!;
}
