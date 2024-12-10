using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtEducationId", "RevisionNo")]
[Table("pt_education_mh")]
public partial class PtEducationMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_education_id")]
    public int PtEducationId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("time_spent")]
    public int? TimeSpent { get; set; }

    [Column("time_unit")]
    public int? TimeUnit { get; set; }

    [Column("education_tstamp", TypeName = "datetime")]
    public DateTime? EducationTstamp { get; set; }

    [Column("education_cmt")]
    [StringLength(255)]
    public string? EducationCmt { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("education_desc")]
    [StringLength(255)]
    public string? EducationDesc { get; set; }

    [Column("education_cat_desc")]
    [StringLength(255)]
    public string? EducationCatDesc { get; set; }

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

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }
}
