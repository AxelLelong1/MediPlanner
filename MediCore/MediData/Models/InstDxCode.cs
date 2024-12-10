using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "ClsSchemeId", "DxCd", "ExamCompId")]
[Table("inst_dx_code")]
public partial class InstDxCode
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("dx_cd")]
    [StringLength(20)]
    public string DxCd { get; set; } = null!;

    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Column("dx_cd_desc")]
    [StringLength(255)]
    public string DxCdDesc { get; set; } = null!;

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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
    [InverseProperty("InstDxCode")]
    public virtual ClsScheme ClsScheme { get; set; } = null!;

    [ForeignKey("ExamCompId")]
    [InverseProperty("InstDxCode")]
    public virtual ExamComp ExamComp { get; set; } = null!;

    [ForeignKey("InstId")]
    [InverseProperty("InstDxCode")]
    public virtual Inst Inst { get; set; } = null!;
}
