using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("EducationResourceId", "InstId")]
[Table("education_resource")]
public partial class EducationResource
{
    [Key]
    [Column("education_resource_id")]
    public int EducationResourceId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("base_typ_id")]
    public int BaseTypId { get; set; }

    [Column("education_resource_typ")]
    [StringLength(1)]
    public string EducationResourceTyp { get; set; } = null!;

    [Column("education_resource_value")]
    [StringLength(255)]
    public string EducationResourceValue { get; set; } = null!;

    [Column("education_resource_desc")]
    [StringLength(255)]
    public string? EducationResourceDesc { get; set; }

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

    [ForeignKey("InstId, BaseTypId")]
    [InverseProperty("EducationResource")]
    public virtual InstBaseTyp InstBaseTyp { get; set; } = null!;
}
