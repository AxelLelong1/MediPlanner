using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MorphCd", "BehaviorCd", "MorphCdSeq", "SiteApplic")]
[Table("icdo_morph_site")]
public partial class IcdoMorphSite
{
    [Key]
    [Column("morph_cd")]
    [StringLength(4)]
    public string MorphCd { get; set; } = null!;

    [Key]
    [Column("behavior_cd")]
    [StringLength(1)]
    public string BehaviorCd { get; set; } = null!;

    [Key]
    [Column("morph_cd_seq")]
    public int MorphCdSeq { get; set; }

    [Key]
    [Column("site_applic")]
    [StringLength(3)]
    public string SiteApplic { get; set; } = null!;

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
