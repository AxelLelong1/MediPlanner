﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtExamId", "PtExamSystemId", "PtExamCompId", "PtExamAttrId", "RevisionNo")]
[Table("pt_exam_attr_mh")]
public partial class PtExamAttrMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_exam_id")]
    public int PtExamId { get; set; }

    [Key]
    [Column("pt_exam_system_id")]
    public int PtExamSystemId { get; set; }

    [Key]
    [Column("pt_exam_comp_id")]
    public int PtExamCompId { get; set; }

    [Key]
    [Column("pt_exam_attr_id")]
    public int PtExamAttrId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("comp_desc")]
    [StringLength(40)]
    public string? CompDesc { get; set; }

    [Column("exam_comp_attr")]
    [StringLength(40)]
    public string? ExamCompAttr { get; set; }

    [Column("exam_asmt_desc")]
    [StringLength(200)]
    public string? ExamAsmtDesc { get; set; }

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

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
