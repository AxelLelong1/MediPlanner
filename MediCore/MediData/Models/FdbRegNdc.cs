using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FdbNdcId", "RegionCode", "LanguageId")]
[Table("FDB_reg_ndc")]
public partial class FdbRegNdc
{
    [Key]
    [Column("fdb_ndc_id")]
    public int FdbNdcId { get; set; }

    [Key]
    [Column("region_code")]
    public int RegionCode { get; set; }

    [Key]
    [Column("language_id")]
    public int LanguageId { get; set; }

    [Column("fdb_agent_id")]
    [StringLength(32)]
    public string FdbAgentId { get; set; } = null!;

    [Column("ndc_cd")]
    [StringLength(11)]
    public string NdcCd { get; set; } = null!;

    [Column("dea_class_cd")]
    [StringLength(1)]
    public string? DeaClassCd { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }
}
