using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "WindowLabel", "MapId")]
[Table("help_index")]
public partial class HelpIndex
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("window_label")]
    [StringLength(30)]
    public string WindowLabel { get; set; } = null!;

    [Key]
    [Column("map_id")]
    public int MapId { get; set; }

    [Column("help_topic")]
    [StringLength(100)]
    public string? HelpTopic { get; set; }

    [Column("display_order")]
    public int? DisplayOrder { get; set; }

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
