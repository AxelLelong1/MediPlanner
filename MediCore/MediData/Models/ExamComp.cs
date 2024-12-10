using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("exam_comp")]
public partial class ExamComp
{
    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Column("exam_cd")]
    [StringLength(1)]
    public string? ExamCd { get; set; }

    [Column("system_typ_id")]
    public int SystemTypId { get; set; }

    [Column("exam_comp_desc")]
    [StringLength(40)]
    public string ExamCompDesc { get; set; } = null!;

    [Column("neg_desc")]
    [StringLength(100)]
    public string? NegDesc { get; set; }

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

    [InverseProperty("ExamComp")]
    public virtual ICollection<InstDxCode> InstDxCode { get; set; } = new List<InstDxCode>();

    [InverseProperty("ExamComp")]
    public virtual ICollection<UserExamComp> UserExamComp { get; set; } = new List<UserExamComp>();

    [InverseProperty("ExamComp")]
    public virtual ICollection<XrefExamCompIcd> XrefExamCompIcd { get; set; } = new List<XrefExamCompIcd>();
}
