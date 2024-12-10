﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "MorphCd", "BehaviorCd", "MorphCdSeq", "CultureCd")]
[Table("icdo_morph_cd_culture")]
public partial class IcdoMorphCdCulture
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

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
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("morph_desc")]
    [StringLength(100)]
    public string MorphDesc { get; set; } = null!;

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

    [Column("varis_histology_cd")]
    [StringLength(16)]
    public string VarisHistologyCd { get; set; } = null!;
}
