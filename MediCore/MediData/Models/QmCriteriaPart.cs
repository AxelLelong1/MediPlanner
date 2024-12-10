using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_criteria_part")]
public partial class QmCriteriaPart
{
    [Key]
    [Column("qmcp_id")]
    public int QmcpId { get; set; }

    [Column("qmcp_typ")]
    [StringLength(20)]
    public string QmcpTyp { get; set; } = null!;

    [Column("qmcp_xml_name")]
    [StringLength(50)]
    public string? QmcpXmlName { get; set; }

    [Column("qmcp_desc")]
    public string? QmcpDesc { get; set; }

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

    [Column("qmcp_guid")]
    [StringLength(100)]
    public string? QmcpGuid { get; set; }

    [InverseProperty("Qmcp")]
    public virtual ICollection<PtQm> PtQm { get; set; } = new List<PtQm>();

    [InverseProperty("QmcpIdDenominatorNavigation")]
    public virtual ICollection<QmCriteria> QmCriteriaQmcpIdDenominatorNavigation { get; set; } = new List<QmCriteria>();

    [InverseProperty("QmcpIdExceptionNavigation")]
    public virtual ICollection<QmCriteria> QmCriteriaQmcpIdExceptionNavigation { get; set; } = new List<QmCriteria>();

    [InverseProperty("QmcpIdExclusionNavigation")]
    public virtual ICollection<QmCriteria> QmCriteriaQmcpIdExclusionNavigation { get; set; } = new List<QmCriteria>();

    [InverseProperty("QmcpIdNumeratorNavigation")]
    public virtual ICollection<QmCriteria> QmCriteriaQmcpIdNumeratorNavigation { get; set; } = new List<QmCriteria>();

    [InverseProperty("QmcpIdPopulationNavigation")]
    public virtual ICollection<QmCriteria> QmCriteriaQmcpIdPopulationNavigation { get; set; } = new List<QmCriteria>();
}
