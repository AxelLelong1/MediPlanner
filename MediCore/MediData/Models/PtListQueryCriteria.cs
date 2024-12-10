using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_list_query_criteria")]
public partial class PtListQueryCriteria
{
    [Key]
    [Column("pt_list_query_criteria_id")]
    public int PtListQueryCriteriaId { get; set; }

    [Column("pt_list_query_id")]
    public int PtListQueryId { get; set; }

    [Column("criteria_typ")]
    public int CriteriaTyp { get; set; }

    [Column("criteria_comparison_operator")]
    [StringLength(7)]
    public string CriteriaComparisonOperator { get; set; } = null!;

    [Column("criteria_logical_operator")]
    [StringLength(3)]
    public string CriteriaLogicalOperator { get; set; } = null!;

    [Column("criteria_priority")]
    public int CriteriaPriority { get; set; }

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

    [InverseProperty("Criteria")]
    public virtual ICollection<PtClinicalNotificationCriteria> PtClinicalNotificationCriteria { get; set; } = new List<PtClinicalNotificationCriteria>();

    [ForeignKey("PtListQueryId")]
    [InverseProperty("PtListQueryCriteria")]
    public virtual PtListQuery PtListQuery { get; set; } = null!;

    [InverseProperty("PtListQueryCriteria")]
    public virtual ICollection<PtListQueryCriteriaValue> PtListQueryCriteriaValue { get; set; } = new List<PtListQueryCriteriaValue>();
}
