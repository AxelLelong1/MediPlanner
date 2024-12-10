using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IcdClsSchemeId", "IcdCd", "IcdoSiteCd", "BehaviorCd", "UnsureInd", "IcdoSiteSeq")]
[Table("xref_icd_icdo")]
[Index("IcdClsSchemeId", "IcdCd", "IcdoSiteCd", Name = "nc1_xref_icd_icdo")]
public partial class XrefIcdIcdo
{
    [Key]
    [Column("icd_cls_scheme_id")]
    public int IcdClsSchemeId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Key]
    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string IcdoSiteCd { get; set; } = null!;

    [Key]
    [Column("behavior_cd")]
    [StringLength(1)]
    public string BehaviorCd { get; set; } = null!;

    [Key]
    [Column("unsure_ind")]
    [StringLength(1)]
    public string UnsureInd { get; set; } = null!;

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

    [Key]
    [Column("icdo_site_seq")]
    public int IcdoSiteSeq { get; set; }
}
