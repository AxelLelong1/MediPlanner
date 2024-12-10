using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "IcdoSiteCd1", "IcdoSiteSeq")]
[Table("icdo_site_cd")]
public partial class IcdoSiteCd
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string IcdoSiteCd1 { get; set; } = null!;

    [Key]
    [Column("icdo_site_seq")]
    public int IcdoSiteSeq { get; set; }

    [Column("icdo_desc")]
    [StringLength(100)]
    public string? IcdoDesc { get; set; }

    [Column("icdo_site_typ")]
    [StringLength(2)]
    public string IcdoSiteTyp { get; set; } = null!;

    [Column("syn_ind")]
    [StringLength(1)]
    public string? SynInd { get; set; }

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

    [ForeignKey("IcdoSiteTyp")]
    [InverseProperty("IcdoSiteCd")]
    public virtual IcdoSiteTyp IcdoSiteTypNavigation { get; set; } = null!;
}
