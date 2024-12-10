using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpClsTypId", "TpClsValueId", "AuthorCd", "EffDate", "HdrCd", "CultureCd")]
[Table("tum_cls_crit_typ_hdr_culture")]
public partial class TumClsCritTypHdrCulture
{
    [Key]
    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Key]
    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Key]
    [Column("author_cd")]
    public int AuthorCd { get; set; }

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Key]
    [Column("hdr_cd")]
    [StringLength(10)]
    public string HdrCd { get; set; } = null!;

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("hdr_desc")]
    [StringLength(100)]
    public string HdrDesc { get; set; } = null!;

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
}
