using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "DtFirstAccess", "InstId", "AppCd")]
[Table("help_usage")]
public partial class HelpUsage
{
    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("dt_first_access", TypeName = "datetime")]
    public DateTime DtFirstAccess { get; set; }

    [Column("dt_last_access", TypeName = "datetime")]
    public DateTime DtLastAccess { get; set; }

    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("window_label")]
    [StringLength(30)]
    public string WindowLabel { get; set; } = null!;

    [Column("map_id")]
    public int MapId { get; set; }

    [Column("help_cnt")]
    public int HelpCnt { get; set; }
}
