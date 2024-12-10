using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IStrengthId", "RegionCode", "LanguageId")]
[Table("FDB_reg_strengths")]
public partial class FdbRegStrengths
{
    [Key]
    [Column("iStrengthId")]
    public int IStrengthId { get; set; }

    [Key]
    [Column("region_code")]
    public int RegionCode { get; set; }

    [Key]
    [Column("language_id")]
    public int LanguageId { get; set; }

    [Column("form_text")]
    [StringLength(255)]
    public string? FormText { get; set; }

    [Column("strength")]
    [StringLength(15)]
    public string? Strength { get; set; }

    [Column("strength_uom")]
    [StringLength(15)]
    public string? StrengthUom { get; set; }
}
