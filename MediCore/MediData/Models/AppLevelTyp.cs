using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("app_level_typ")]
public partial class AppLevelTyp
{
    [Key]
    [Column("app_level_typ_no")]
    public int AppLevelTypNo { get; set; }

    [Column("app_level_file_ext")]
    [StringLength(3)]
    public string AppLevelFileExt { get; set; } = null!;

    [Column("app_level_typ_path")]
    [StringLength(100)]
    public string AppLevelTypPath { get; set; } = null!;

    [Column("app_level_typ_desc")]
    [StringLength(30)]
    public string AppLevelTypDesc { get; set; } = null!;

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

    [InverseProperty("AppLevelTypNoNavigation")]
    public virtual ICollection<AppLevel> AppLevel { get; set; } = new List<AppLevel>();

    [InverseProperty("AppLevelTypNoNavigation")]
    public virtual ICollection<AppLevelXref> AppLevelXref { get; set; } = new List<AppLevelXref>();
}
