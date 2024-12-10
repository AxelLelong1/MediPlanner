using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "AppLevelTypNo")]
[Table("app_level_xref")]
public partial class AppLevelXref
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("app_level_typ_no")]
    public int AppLevelTypNo { get; set; }

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

    [ForeignKey("AppCd")]
    [InverseProperty("AppLevelXref")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [ForeignKey("AppLevelTypNo")]
    [InverseProperty("AppLevelXref")]
    public virtual AppLevelTyp AppLevelTypNoNavigation { get; set; } = null!;
}
