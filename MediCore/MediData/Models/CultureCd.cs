using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("culture_cd")]
public partial class CultureCd
{
    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd1 { get; set; } = null!;

    [Column("language_cd")]
    [StringLength(3)]
    public string LanguageCd { get; set; } = null!;

    [Column("country_cd")]
    [StringLength(3)]
    public string? CountryCd { get; set; }

    [Column("culture_desc")]
    [StringLength(255)]
    public string? CultureDesc { get; set; }

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
