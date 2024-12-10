using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IcdGroupId", "IcdCd", "ClsSchemeId")]
[Table("xref_icd_group")]
public partial class XrefIcdGroup
{
    [Key]
    [Column("icd_group_id")]
    public int IcdGroupId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("display_order_no")]
    public int? DisplayOrderNo { get; set; }

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

    [ForeignKey("ClsSchemeId, IcdCd")]
    [InverseProperty("XrefIcdGroup")]
    public virtual IcdDx IcdDx { get; set; } = null!;

    [ForeignKey("IcdGroupId")]
    [InverseProperty("XrefIcdGroup")]
    public virtual IcdGroup IcdGroup { get; set; } = null!;
}
