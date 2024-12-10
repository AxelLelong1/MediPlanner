using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpClsTypId", "TpClsValueId")]
[Table("tp_cls_value")]
public partial class TpClsValue
{
    [Key]
    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Key]
    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Column("tp_cls_value_desc")]
    [StringLength(40)]
    public string TpClsValueDesc { get; set; } = null!;

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

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    [InverseProperty("TpClsValue")]
    public virtual ICollection<TpClsGroup> TpClsGroup { get; set; } = new List<TpClsGroup>();

    [ForeignKey("TpClsTypId")]
    [InverseProperty("TpClsValue")]
    public virtual TpClsTyp TpClsTyp { get; set; } = null!;

    [InverseProperty("TpClsValue")]
    public virtual ICollection<TumClsScheme> TumClsScheme { get; set; } = new List<TumClsScheme>();

    [InverseProperty("TpClsValue")]
    public virtual ICollection<XrefIcdoTpCls> XrefIcdoTpCls { get; set; } = new List<XrefIcdoTpCls>();

    [InverseProperty("TpClsValue")]
    public virtual ICollection<XrefSiteExam> XrefSiteExam { get; set; } = new List<XrefSiteExam>();

    [InverseProperty("TpClsValue")]
    public virtual ICollection<XrefSiteTest> XrefSiteTest { get; set; } = new List<XrefSiteTest>();
}
