using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TpClsTypId", "TpClsValueId", "AuthorCd", "EffDate", "CritCd", "PtTumStgId")]
[Table("pt_tum_cls_values")]
public partial class PtTumClsValues
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

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

    [Column("tum_cls_date", TypeName = "datetime")]
    public DateTime TumClsDate { get; set; }

    [Column("chronology")]
    [StringLength(1)]
    public string? Chronology { get; set; }

    [Key]
    [Column("pt_tum_stg_id")]
    public int PtTumStgId { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string? ApprFlag { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtTumClsValues")]
    public virtual Pt Pt { get; set; } = null!;
}
