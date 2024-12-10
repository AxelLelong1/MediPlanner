using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtDxCodeId", "PtId", "PtDxId")]
[Table("pt_dx_code")]
[Index("PtId", "PtDxId", Name = "nc1_pt_dx_code")]
public partial class PtDxCode
{
    [Key]
    [Column("pt_dx_code_id")]
    public int PtDxCodeId { get; set; }

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_dx_id")]
    public int PtDxId { get; set; }

    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("dx_cd")]
    [StringLength(20)]
    public string DxCd { get; set; } = null!;

    [Column("dx_cd_desc")]
    [StringLength(255)]
    public string DxCdDesc { get; set; } = null!;

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

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

    [ForeignKey("ClsSchemeId")]
    [InverseProperty("PtDxCode")]
    public virtual ClsScheme ClsScheme { get; set; } = null!;

    [ForeignKey("PtId, PtDxId")]
    [InverseProperty("PtDxCode")]
    public virtual PtDx PtDx { get; set; } = null!;
}
