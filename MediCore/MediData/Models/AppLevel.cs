using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppVersNo", "AppBuildNo", "AppLevelNo")]
[Table("app_level")]
public partial class AppLevel
{
    [Key]
    [Column("app_vers_no")]
    [StringLength(10)]
    public string AppVersNo { get; set; } = null!;

    [Key]
    [Column("app_build_no")]
    [StringLength(10)]
    public string AppBuildNo { get; set; } = null!;

    [Key]
    [Column("app_level_no")]
    public int AppLevelNo { get; set; }

    [Column("pbd_zip_file", TypeName = "image")]
    public byte[]? PbdZipFile { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("app_level_typ_no")]
    public int? AppLevelTypNo { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [ForeignKey("AppLevelTypNo")]
    [InverseProperty("AppLevel")]
    public virtual AppLevelTyp? AppLevelTypNoNavigation { get; set; }
}
