using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "DeptId")]
[Table("inst_dept")]
public partial class InstDept
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("dept_id")]
    public int DeptId { get; set; }

    [Column("dept_name")]
    [StringLength(30)]
    public string? DeptName { get; set; }

    [Column("dept_desc")]
    [StringLength(80)]
    public string? DeptDesc { get; set; }

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

    [Column("dept_tel")]
    [StringLength(28)]
    public string? DeptTel { get; set; }

    [Column("dept_tel_ext")]
    [StringLength(10)]
    public string? DeptTelExt { get; set; }

    [Column("dept_tel_fmt_id")]
    public int? DeptTelFmtId { get; set; }

    [ForeignKey("DeptTelFmtId")]
    [InverseProperty("InstDept")]
    public virtual FmtField? DeptTelFmt { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("InstDept")]
    public virtual Inst Inst { get; set; } = null!;
}
