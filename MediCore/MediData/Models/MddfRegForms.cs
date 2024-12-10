using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IBaseFormulationId", "RegionCode", "LanguageId")]
[Table("MDDF_reg_forms")]
public partial class MddfRegForms
{
    [Key]
    [Column("iBaseFormulationId")]
    public int IBaseFormulationId { get; set; }

    [Key]
    [Column("region_code")]
    public int RegionCode { get; set; }

    [Key]
    [Column("language_id")]
    public int LanguageId { get; set; }

    [Column("form_text")]
    [StringLength(255)]
    public string? FormText { get; set; }
}
