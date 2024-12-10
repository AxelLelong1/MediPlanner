using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_dict")]
public partial class MedDict
{
    [Key]
    [Column("field_id")]
    [StringLength(4)]
    public string FieldId { get; set; } = null!;

    [Column("field_desc")]
    [StringLength(35)]
    public string FieldDesc { get; set; } = null!;

    [Column("field_type")]
    [StringLength(1)]
    public string? FieldType { get; set; }

    [Column("field_length")]
    [StringLength(3)]
    public string? FieldLength { get; set; }

    [Column("imp_dec_flag")]
    [StringLength(1)]
    public string? ImpDecFlag { get; set; }

    [Column("dec_places")]
    [StringLength(2)]
    public string? DecPlaces { get; set; }

    [Column("field_val_flag")]
    [StringLength(1)]
    public string? FieldValFlag { get; set; }

    [Column("field_abr_flag")]
    [StringLength(1)]
    public string? FieldAbrFlag { get; set; }

    [Column("reserve")]
    [StringLength(7)]
    public string? Reserve { get; set; }

    [Column("activity_cd")]
    [StringLength(1)]
    public string? ActivityCd { get; set; }

    [Column("last_chg_date")]
    [StringLength(8)]
    public string? LastChgDate { get; set; }

    [Column("del_flag")]
    [StringLength(1)]
    public string? DelFlag { get; set; }

    [Column("optx_chg_date", TypeName = "datetime")]
    public DateTime? OptxChgDate { get; set; }
}
