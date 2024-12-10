using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TcgpiKey", "RecType")]
[Table("med_tc_gpi")]
[Index("TcgpiKey", Name = "nc1_med_tc_gpi")]
[Index("RecType", Name = "nc2_med_tc_gpi")]
public partial class MedTcGpi
{
    [Key]
    [Column("tcgpi_key")]
    [StringLength(14)]
    public string TcgpiKey { get; set; } = null!;

    [Key]
    [Column("rec_type")]
    [StringLength(1)]
    public string RecType { get; set; } = null!;

    [Column("tcgpi_name")]
    [StringLength(60)]
    public string? TcgpiName { get; set; }

    [Column("reserve")]
    [StringLength(12)]
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

    [Column("cls_desc")]
    [StringLength(40)]
    public string? ClsDesc { get; set; }
}
