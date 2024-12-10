using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("xs_config")]
[Index("ConfigClass", "ConfigName", "ConfigKey", Name = "nc1_xs_config")]
public partial class XsConfig
{
    [Key]
    [Column("xs_config")]
    public int XsConfig1 { get; set; }

    [Column("config_class")]
    [StringLength(255)]
    public string ConfigClass { get; set; } = null!;

    [Column("config_name")]
    [StringLength(255)]
    public string ConfigName { get; set; } = null!;

    [Column("config_key")]
    [StringLength(50)]
    public string ConfigKey { get; set; } = null!;

    [Column("config_value")]
    [StringLength(255)]
    public string ConfigValue { get; set; } = null!;

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
