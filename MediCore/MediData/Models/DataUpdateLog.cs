﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("data_update_log")]
public partial class DataUpdateLog
{
    [Key]
    [Column("data_update_log_id")]
    public int DataUpdateLogId { get; set; }

    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("scheme_name")]
    [StringLength(64)]
    public string SchemeName { get; set; } = null!;

    [Column("data_effective_date", TypeName = "datetime")]
    public DateTime DataEffectiveDate { get; set; }

    [Column("update_start", TypeName = "datetime")]
    public DateTime UpdateStart { get; set; }

    [Column("update_end", TypeName = "datetime")]
    public DateTime UpdateEnd { get; set; }

    [Column("update_status")]
    [StringLength(1)]
    public string UpdateStatus { get; set; } = null!;

    [Column("update_fail_msg")]
    [StringLength(255)]
    public string? UpdateFailMsg { get; set; }

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

    [Column("update_method")]
    [StringLength(10)]
    public string? UpdateMethod { get; set; }
}
