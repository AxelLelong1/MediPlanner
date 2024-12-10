using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CultureCd", "StageCd")]
[Table("stage_def_culture")]
public partial class StageDefCulture
{
    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Key]
    [Column("stage_cd")]
    [StringLength(20)]
    public string StageCd { get; set; } = null!;

    [Column("stage_desc")]
    [StringLength(20)]
    public string StageDesc { get; set; } = null!;

    [Column("stage_desc_en")]
    [StringLength(20)]
    public string StageDescEn { get; set; } = null!;

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
}
