using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fbm_ltr")]
public partial class FbmLtr
{
    [Key]
    [Column("fbm_ltr_id")]
    public int FbmLtrId { get; set; }

    [Column("ltr_name")]
    [StringLength(255)]
    public string LtrName { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

    [Column("rcpt_cd")]
    [StringLength(1)]
    public string RcptCd { get; set; } = null!;

    [Column("pt_notification_ind")]
    [StringLength(1)]
    public string PtNotificationInd { get; set; } = null!;

    [Column("template_inst_id")]
    [StringLength(30)]
    public string? TemplateInstId { get; set; }

    [Column("template_id")]
    public int? TemplateId { get; set; }

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
}
