using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_criteria_instance")]
[Index("QmiId", "QmciId", "QmcId", "LastUpdatedInstId", "LastUpdatedUserid", Name = "nc1_qm_criteria_instance")]
public partial class QmCriteriaInstance
{
    [Key]
    [Column("qmci_id")]
    public int QmciId { get; set; }

    [Column("qmi_id")]
    public int QmiId { get; set; }

    [Column("qmc_id")]
    public int QmcId { get; set; }

    [Column("last_updated_tstamp", TypeName = "datetime")]
    public DateTime? LastUpdatedTstamp { get; set; }

    [Column("last_updated_userid")]
    [StringLength(255)]
    public string? LastUpdatedUserid { get; set; }

    [Column("last_updated_inst_id")]
    [StringLength(30)]
    public string? LastUpdatedInstId { get; set; }

    [Column("last_updated_elapsed_time")]
    public int? LastUpdatedElapsedTime { get; set; }

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

    [Column("total_population")]
    public int? TotalPopulation { get; set; }

    [Column("total_qualify")]
    public int? TotalQualify { get; set; }

    [Column("total_met")]
    public int? TotalMet { get; set; }

    [Column("total_manual")]
    public int? TotalManual { get; set; }

    [ForeignKey("QmcId")]
    [InverseProperty("QmCriteriaInstance")]
    public virtual QmCriteria Qmc { get; set; } = null!;

    [ForeignKey("QmiId")]
    [InverseProperty("QmCriteriaInstance")]
    public virtual QmInstance Qmi { get; set; } = null!;
}
