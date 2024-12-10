using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "IcdCd")]
[Table("icd_procedure")]
[Index("IcdCd", Name = "nc1_icd_procedure")]
public partial class IcdProcedure
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Column("short_title")]
    [StringLength(60)]
    public string ShortTitle { get; set; } = null!;

    [Column("full_title")]
    [StringLength(250)]
    public string FullTitle { get; set; } = null!;

    [Column("cat")]
    [StringLength(1)]
    public string Cat { get; set; } = null!;

    [Column("subdivided")]
    [StringLength(1)]
    public string Subdivided { get; set; } = null!;

    [Column("sex")]
    [StringLength(1)]
    public string? Sex { get; set; }

    [Column("age_cd")]
    [StringLength(1)]
    public string? AgeCd { get; set; }

    [Column("list_b_cd")]
    [StringLength(3)]
    public string? ListBCd { get; set; }

    [Column("procedure_cls")]
    [StringLength(3)]
    public string? ProcedureCls { get; set; }

    [Column("operating_room")]
    [StringLength(1)]
    public string? OperatingRoom { get; set; }

    [Column("medicare_cd")]
    [StringLength(1)]
    public string? MedicareCd { get; set; }
}
