using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "StkhId", "CompliancePrdId")]
[Table("pt_provider_mu")]
public partial class PtProviderMu
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

    [Column("no_visits")]
    public int? NoVisits { get; set; }

    [Column("visit_ind")]
    [StringLength(1)]
    public string? VisitInd { get; set; }

    [Column("care_trans_in_ind")]
    [StringLength(1)]
    public string? CareTransInInd { get; set; }

    [Column("care_trans_out_ind")]
    [StringLength(1)]
    public string? CareTransOutInd { get; set; }

    [Column("cpoe_ind")]
    [StringLength(1)]
    public string? CpoeInd { get; set; }

    [Column("lab_ind")]
    [StringLength(1)]
    public string? LabInd { get; set; }

    [Column("no_lab_ord")]
    public int? NoLabOrd { get; set; }

    [Column("no_lab_result")]
    public int? NoLabResult { get; set; }

    [Column("erx_ind")]
    [StringLength(1)]
    public string? ErxInd { get; set; }

    [Column("no_erx_ord")]
    public int? NoErxOrd { get; set; }

    [Column("no_erx_sent")]
    public int? NoErxSent { get; set; }

    [Column("visit_sum_ind")]
    [StringLength(1)]
    public string? VisitSumInd { get; set; }

    [Column("no_visit_sum_rqst")]
    public int? NoVisitSumRqst { get; set; }

    [Column("no_visit_sum_provided")]
    public int? NoVisitSumProvided { get; set; }

    [Column("info_rqst_ind")]
    [StringLength(1)]
    public string? InfoRqstInd { get; set; }

    [Column("no_info_rqst")]
    public int? NoInfoRqst { get; set; }

    [Column("no_info_rqst_provided")]
    public int? NoInfoRqstProvided { get; set; }

    [Column("care_sum_ind")]
    [StringLength(1)]
    public string? CareSumInd { get; set; }

    [Column("no_care_sum_rqst")]
    public int? NoCareSumRqst { get; set; }

    [Column("no_care_sum_provided")]
    public int? NoCareSumProvided { get; set; }

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

    [Column("no_cpoe_lab_ord")]
    public int? NoCpoeLabOrd { get; set; }

    [Column("no_cpoe_med_ord")]
    public int? NoCpoeMedOrd { get; set; }

    [Column("no_cpoe_rad_ord")]
    public int? NoCpoeRadOrd { get; set; }

    [Column("rem_info_req_ind")]
    [StringLength(1)]
    public string? RemInfoReqInd { get; set; }

    [Column("vitals_info_req_ind")]
    [StringLength(1)]
    public string? VitalsInfoReqInd { get; set; }

    [Column("vitals_ind")]
    [StringLength(1)]
    public string? VitalsInd { get; set; }

    [Column("ht_ind")]
    [StringLength(1)]
    public string? HtInd { get; set; }

    [Column("wt_ind")]
    [StringLength(1)]
    public string? WtInd { get; set; }

    [Column("bmi_ind")]
    [StringLength(1)]
    public string? BmiInd { get; set; }

    [Column("systolic_ind")]
    [StringLength(1)]
    public string? SystolicInd { get; set; }

    [Column("diastolic_ind")]
    [StringLength(1)]
    public string? DiastolicInd { get; set; }

    [Column("message_ind")]
    [StringLength(1)]
    public string? MessageInd { get; set; }

    [Column("no_image_results")]
    public int? NoImageResults { get; set; }

    [Column("no_image_access")]
    public int? NoImageAccess { get; set; }

    [Column("care_sum_electr_transmit_ind")]
    [StringLength(1)]
    public string? CareSumElectrTransmitInd { get; set; }

    [Column("no_toc_in")]
    public int? NoTocIn { get; set; }

    [Column("no_toc_in_recon")]
    public int? NoTocInRecon { get; set; }

    [Column("no_care_sum_elec_provided")]
    public int? NoCareSumElecProvided { get; set; }

    [Column("no_cpoe_med_ord_alt")]
    public int? NoCpoeMedOrdAlt { get; set; }

    [Column("no_care_sum_rcvd")]
    public int? NoCareSumRcvd { get; set; }

    [Column("no_care_sum_incrp")]
    public int? NoCareSumIncrp { get; set; }

    [Column("timely_portal_access")]
    [StringLength(1)]
    public string? TimelyPortalAccess { get; set; }

    [ForeignKey("CompliancePrdId")]
    [InverseProperty("PtProviderMu")]
    public virtual CompliancePrd CompliancePrd { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtProviderMu")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("StkhId")]
    [InverseProperty("PtProviderMu")]
    public virtual Stkh Stkh { get; set; } = null!;
}
