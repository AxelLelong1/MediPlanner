using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpClsTypId", "TpClsValueId", "AuthorCd", "EffDate", "CritCd")]
[Table("tum_cls_crit_value")]
public partial class TumClsCritValue
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
    [Column("crit_cd")]
    [StringLength(10)]
    public string CritCd { get; set; } = null!;

    [Column("crit_desc")]
    public string CritDesc { get; set; } = null!;

    [Column("crit_typ_cd")]
    [StringLength(10)]
    public string CritTypCd { get; set; } = null!;

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("hdr_cd")]
    [StringLength(10)]
    public string? HdrCd { get; set; }

    [Column("assess_cd")]
    [StringLength(10)]
    public string? AssessCd { get; set; }

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

    [ForeignKey("TpClsTypId, TpClsValueId, AuthorCd, EffDate, CritTypCd")]
    [InverseProperty("TumClsCritValue")]
    public virtual TumClsCritTyp TumClsCritTyp { get; set; } = null!;

    [ForeignKey("TpClsTypId, TpClsValueId, AuthorCd, EffDate, HdrCd")]
    [InverseProperty("TumClsCritValue")]
    public virtual TumClsCritTypHdr? TumClsCritTypHdr { get; set; }
}
