using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_instance")]
[Index("QmId", "CompliancePrdId", Name = "nc1_qm_instance", IsUnique = true)]
public partial class QmInstance
{
    [Key]
    [Column("qmi_id")]
    public int QmiId { get; set; }

    [Column("qm_id")]
    public int QmId { get; set; }

    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

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

    [ForeignKey("CompliancePrdId")]
    [InverseProperty("QmInstance")]
    public virtual CompliancePrd CompliancePrd { get; set; } = null!;

    [InverseProperty("Qmi")]
    public virtual ICollection<PtQm> PtQm { get; set; } = new List<PtQm>();

    [InverseProperty("Qmi")]
    public virtual ICollection<PtQmDetail> PtQmDetail { get; set; } = new List<PtQmDetail>();

    [ForeignKey("QmId")]
    [InverseProperty("QmInstance")]
    public virtual Qm Qm { get; set; } = null!;

    [InverseProperty("Qmi")]
    public virtual ICollection<QmCriteriaInstance> QmCriteriaInstance { get; set; } = new List<QmCriteriaInstance>();

    [InverseProperty("Qmi")]
    public virtual ICollection<QmInstanceSubscription> QmInstanceSubscription { get; set; } = new List<QmInstanceSubscription>();
}
