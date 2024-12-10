using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InsPrecertTyp", "WindowName")]
[Table("ins_precert_alert_window")]
public partial class InsPrecertAlertWindow
{
    [Key]
    [Column("ins_precert_typ")]
    public int InsPrecertTyp { get; set; }

    [Key]
    [Column("window_name")]
    [StringLength(40)]
    public string WindowName { get; set; } = null!;

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

    [ForeignKey("InsPrecertTyp")]
    [InverseProperty("InsPrecertAlertWindow")]
    public virtual InsPrecertTyp InsPrecertTypNavigation { get; set; } = null!;
}
