using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "Userid", "TpClsTypId", "TpClsValueId", "SystemTypId")]
[Table("xref_site_exam")]
public partial class XrefSiteExam
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Key]
    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Key]
    [Column("system_typ_id")]
    public int SystemTypId { get; set; }

    [Column("system_desc")]
    [StringLength(30)]
    public string? SystemDesc { get; set; }

    [Column("exam_cd")]
    [StringLength(1)]
    public string? ExamCd { get; set; }

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

    [ForeignKey("InstId, SystemTypId")]
    [InverseProperty("XrefSiteExam")]
    public virtual InstExamSystem InstExamSystem { get; set; } = null!;

    [ForeignKey("TpClsTypId, TpClsValueId")]
    [InverseProperty("XrefSiteExam")]
    public virtual TpClsValue TpClsValue { get; set; } = null!;
}
