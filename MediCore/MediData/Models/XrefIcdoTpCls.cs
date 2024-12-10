using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IcdoSiteCd", "TpClsTypId", "TpClsValueId")]
[Table("xref_icdo_tp_cls")]
[Index("TpClsTypId", "TpClsValueId", Name = "nc1_xref_icdo_tp_cls")]
public partial class XrefIcdoTpCls
{
    [Key]
    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string IcdoSiteCd { get; set; } = null!;

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

    [Column("dflt_icdo_for_site_ind")]
    [StringLength(1)]
    public string? DfltIcdoForSiteInd { get; set; }

    [ForeignKey("TpClsTypId, TpClsValueId")]
    [InverseProperty("XrefIcdoTpCls")]
    public virtual TpClsValue TpClsValue { get; set; } = null!;
}
