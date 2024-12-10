using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "IcdCd", "TpClsTypId", "TpClsValueId")]
[Table("xref_icd_tp_cls")]
public partial class XrefIcdTpCls
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Key]
    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Key]
    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
