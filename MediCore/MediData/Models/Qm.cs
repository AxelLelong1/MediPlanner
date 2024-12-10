using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm")]
public partial class Qm
{
    [Key]
    [Column("qm_id")]
    public int QmId { get; set; }

    [Column("qm_reference")]
    [StringLength(10)]
    public string? QmReference { get; set; }

    [Column("qm_name")]
    [StringLength(150)]
    public string QmName { get; set; } = null!;

    [Column("qm_desc")]
    public string QmDesc { get; set; } = null!;

    [Column("rationale")]
    public string Rationale { get; set; } = null!;

    [Column("clinical_recommendation")]
    public string ClinicalRecommendation { get; set; } = null!;

    [Column("definitions_xml_name")]
    [StringLength(50)]
    public string? DefinitionsXmlName { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

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

    [Column("qm_vers_no")]
    public int? QmVersNo { get; set; }

    [Column("qm_cms_no")]
    [StringLength(10)]
    public string? QmCmsNo { get; set; }

    [Column("qm_guid")]
    [StringLength(100)]
    public string? QmGuid { get; set; }

    [Column("qm_vers_neutral_guid")]
    [StringLength(100)]
    public string? QmVersNeutralGuid { get; set; }

    [Column("episode_of_care_ind")]
    [StringLength(1)]
    public string? EpisodeOfCareInd { get; set; }

    [InverseProperty("Qm")]
    public virtual ICollection<QmCriteria> QmCriteria { get; set; } = new List<QmCriteria>();

    [InverseProperty("Qm")]
    public virtual ICollection<QmCulture> QmCulture { get; set; } = new List<QmCulture>();

    [InverseProperty("Qm")]
    public virtual ICollection<QmInstance> QmInstance { get; set; } = new List<QmInstance>();

    [InverseProperty("Qm")]
    public virtual ICollection<XrefQmValueSetQm> XrefQmValueSetQm { get; set; } = new List<XrefQmValueSetQm>();
}
