using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "WindowLabel")]
[Table("help_kwrd")]
public partial class HelpKwrd
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("window_label")]
    [StringLength(30)]
    public string WindowLabel { get; set; } = null!;

    [Column("hlp_kwrd")]
    [StringLength(75)]
    public string HlpKwrd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("HelpKwrd")]
    public virtual App AppCdNavigation { get; set; } = null!;
}
