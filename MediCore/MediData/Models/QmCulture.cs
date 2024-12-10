using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("QmId", "CultureCd")]
[Table("qm_culture")]
public partial class QmCulture
{
    [Key]
    [Column("qm_id")]
    public int QmId { get; set; }

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("qm_name")]
    [StringLength(150)]
    public string QmName { get; set; } = null!;

    [Column("qm_desc")]
    public string QmDesc { get; set; } = null!;

    [Column("rationale")]
    public string Rationale { get; set; } = null!;

    [Column("clinical_recommendation")]
    public string ClinicalRecommendation { get; set; } = null!;

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

    [ForeignKey("QmId")]
    [InverseProperty("QmCulture")]
    public virtual Qm Qm { get; set; } = null!;
}
