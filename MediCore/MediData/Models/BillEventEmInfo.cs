using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "BillEventId", "PtVisitId")]
[Table("bill_event_em_info")]
public partial class BillEventEmInfo
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("bill_event_id")]
    public int BillEventId { get; set; }

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("bill_em_cat_typ")]
    public int? BillEmCatTyp { get; set; }

    [Column("duration_ind")]
    [StringLength(1)]
    public string DurationInd { get; set; } = null!;

    [Column("duration_mins")]
    public int? DurationMins { get; set; }

    [Column("hpi_optx_count")]
    public int? HpiOptxCount { get; set; }

    [Column("hpi_actual_count")]
    public int? HpiActualCount { get; set; }

    [Column("ros_optx_count")]
    public int? RosOptxCount { get; set; }

    [Column("ros_actual_count")]
    public int? RosActualCount { get; set; }

    [Column("pfsh_past_ind")]
    [StringLength(1)]
    public string? PfshPastInd { get; set; }

    [Column("pfsh_family_ind")]
    [StringLength(1)]
    public string? PfshFamilyInd { get; set; }

    [Column("pfsh_social_ind")]
    [StringLength(1)]
    public string? PfshSocialInd { get; set; }

    [Column("pe_optx_count")]
    public int? PeOptxCount { get; set; }

    [Column("pe_actual_count")]
    public int? PeActualCount { get; set; }

    [Column("mdm_decision_typ")]
    public int? MdmDecisionTyp { get; set; }

    [Column("mdm_dx_typ")]
    public int? MdmDxTyp { get; set; }

    [Column("mdm_data_typ")]
    public int? MdmDataTyp { get; set; }

    [Column("mdm_risk_typ")]
    public int? MdmRiskTyp { get; set; }

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

    [ForeignKey("BillEmCatTyp")]
    [InverseProperty("BillEventEmInfo")]
    public virtual BillEmCatTyp? BillEmCatTypNavigation { get; set; }

    [ForeignKey("PtId, BillEventId, PtVisitId")]
    [InverseProperty("BillEventEmInfo")]
    public virtual BillEvent BillEvent { get; set; } = null!;

    [ForeignKey("MdmDataTyp")]
    [InverseProperty("BillEventEmInfo")]
    public virtual BillEmDataTyp? MdmDataTypNavigation { get; set; }

    [ForeignKey("MdmDecisionTyp")]
    [InverseProperty("BillEventEmInfo")]
    public virtual BillEmDecisionTyp? MdmDecisionTypNavigation { get; set; }

    [ForeignKey("MdmDxTyp")]
    [InverseProperty("BillEventEmInfo")]
    public virtual BillEmDxTyp? MdmDxTypNavigation { get; set; }

    [ForeignKey("MdmRiskTyp")]
    [InverseProperty("BillEventEmInfo")]
    public virtual BillEmRiskTyp? MdmRiskTypNavigation { get; set; }
}
