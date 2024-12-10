using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("abnormal_flag_cd")]
public partial class AbnormalFlagCd
{
    [Key]
    [Column("abnormal_flag_cd")]
    [StringLength(5)]
    public string AbnormalFlagCd1 { get; set; } = null!;

    [Column("abnormal_flag_desc")]
    [StringLength(40)]
    public string? AbnormalFlagDesc { get; set; }

    [Column("display_color")]
    [StringLength(8)]
    public string? DisplayColor { get; set; }

    [Column("send_alert_ind")]
    [StringLength(1)]
    public string? SendAlertInd { get; set; }

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

    [Column("hl7_mapped_cd")]
    [StringLength(7)]
    public string? Hl7MappedCd { get; set; }

    [Column("hl7_mapped_desc")]
    [StringLength(40)]
    public string? Hl7MappedDesc { get; set; }
}
