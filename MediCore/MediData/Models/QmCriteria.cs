using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_criteria")]
public partial class QmCriteria
{
    [Key]
    [Column("qmc_id")]
    public int QmcId { get; set; }

    [Column("qm_id")]
    public int QmId { get; set; }

    [Column("qmc_unique_desc")]
    public string QmcUniqueDesc { get; set; } = null!;

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("qmcp_id_population")]
    public int? QmcpIdPopulation { get; set; }

    [Column("qmcp_id_exclusion")]
    public int? QmcpIdExclusion { get; set; }

    [Column("qmcp_id_denominator")]
    public int? QmcpIdDenominator { get; set; }

    [Column("qmcp_id_numerator")]
    public int? QmcpIdNumerator { get; set; }

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

    [Column("qmcp_id_exception")]
    public int? QmcpIdException { get; set; }

    [ForeignKey("QmId")]
    [InverseProperty("QmCriteria")]
    public virtual Qm Qm { get; set; } = null!;

    [InverseProperty("Qmc")]
    public virtual ICollection<QmCriteriaCulture> QmCriteriaCulture { get; set; } = new List<QmCriteriaCulture>();

    [InverseProperty("Qmc")]
    public virtual ICollection<QmCriteriaInstance> QmCriteriaInstance { get; set; } = new List<QmCriteriaInstance>();

    [ForeignKey("QmcpIdDenominator")]
    [InverseProperty("QmCriteriaQmcpIdDenominatorNavigation")]
    public virtual QmCriteriaPart? QmcpIdDenominatorNavigation { get; set; }

    [ForeignKey("QmcpIdException")]
    [InverseProperty("QmCriteriaQmcpIdExceptionNavigation")]
    public virtual QmCriteriaPart? QmcpIdExceptionNavigation { get; set; }

    [ForeignKey("QmcpIdExclusion")]
    [InverseProperty("QmCriteriaQmcpIdExclusionNavigation")]
    public virtual QmCriteriaPart? QmcpIdExclusionNavigation { get; set; }

    [ForeignKey("QmcpIdNumerator")]
    [InverseProperty("QmCriteriaQmcpIdNumeratorNavigation")]
    public virtual QmCriteriaPart? QmcpIdNumeratorNavigation { get; set; }

    [ForeignKey("QmcpIdPopulation")]
    [InverseProperty("QmCriteriaQmcpIdPopulationNavigation")]
    public virtual QmCriteriaPart? QmcpIdPopulationNavigation { get; set; }
}
