using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_val")]
public partial class MedVal
{
    [Key]
    [Column("med_val_id")]
    public int MedValId { get; set; }

    [Column("field_id")]
    [StringLength(4)]
    public string FieldId { get; set; } = null!;

    [Column("field_value")]
    [StringLength(15)]
    public string? FieldValue { get; set; }

    [Column("value_desc")]
    [StringLength(40)]
    public string ValueDesc { get; set; } = null!;

    [Column("value_abrev")]
    [StringLength(15)]
    public string? ValueAbrev { get; set; }

    [Column("reserve")]
    [StringLength(13)]
    public string? Reserve { get; set; }

    [Column("activity_cd")]
    [StringLength(1)]
    public string? ActivityCd { get; set; }

    [Column("last_chg_dt")]
    [StringLength(8)]
    public string? LastChgDt { get; set; }

    [Column("del_flag")]
    [StringLength(1)]
    public string? DelFlag { get; set; }

    [Column("optx_chg_date", TypeName = "datetime")]
    public DateTime? OptxChgDate { get; set; }

    [Column("language_cd")]
    [StringLength(2)]
    public string? LanguageCd { get; set; }
}
