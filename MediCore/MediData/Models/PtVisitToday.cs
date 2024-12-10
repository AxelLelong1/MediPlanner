using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId")]
[Table("pt_visit_today")]
[Index("VisitInstId", "VisitStartTstamp", Name = "nc1_pt_visit_today")]
public partial class PtVisitToday
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("visit_inst_id")]
    [StringLength(30)]
    public string? VisitInstId { get; set; }

    [Column("date_time_sch", TypeName = "datetime")]
    public DateTime? DateTimeSch { get; set; }

    [Column("visit_start_tstamp", TypeName = "datetime")]
    public DateTime? VisitStartTstamp { get; set; }

    [Column("visit_typ")]
    public int? VisitTyp { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("userid_link")]
    [StringLength(255)]
    public string? UseridLink { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("visit_clinic_id")]
    public int? VisitClinicId { get; set; }

    [Column("new_provider_ind")]
    [StringLength(1)]
    public string? NewProviderInd { get; set; }

    [Column("new_inst_ind")]
    [StringLength(1)]
    public string? NewInstInd { get; set; }

    [Column("pt_arrive_ind")]
    [StringLength(1)]
    public string? PtArriveInd { get; set; }

    [Column("pt_attend_ind")]
    [StringLength(1)]
    public string? PtAttendInd { get; set; }

    [Column("tentative_ind")]
    [StringLength(1)]
    public string? TentativeInd { get; set; }

    [Column("pt_tp_amend")]
    [StringLength(1)]
    public string? PtTpAmend { get; set; }

    [Column("sch_cmt")]
    [StringLength(2000)]
    public string? SchCmt { get; set; }

    [Column("pt_instr_cmt")]
    [StringLength(255)]
    public string? PtInstrCmt { get; set; }

    [Column("visit_financial_status_typ")]
    public int? VisitFinancialStatusTyp { get; set; }

    [Column("visit_financial_status_cmt")]
    [StringLength(255)]
    public string? VisitFinancialStatusCmt { get; set; }

    [Column("pt_last_name")]
    [StringLength(30)]
    public string? PtLastName { get; set; }

    [Column("pt_first_name")]
    [StringLength(30)]
    public string? PtFirstName { get; set; }

    [Column("pt_initial")]
    [StringLength(2)]
    public string? PtInitial { get; set; }

    [Column("pt_dob", TypeName = "datetime")]
    public DateTime? PtDob { get; set; }

    [Column("pt_dob_cd")]
    public int? PtDobCd { get; set; }

    [Column("pt_key_value")]
    [StringLength(25)]
    public string? PtKeyValue { get; set; }

    [Column("sin_ssn")]
    [StringLength(20)]
    public string? SinSsn { get; set; }

    [Column("citizenship_id")]
    public int? CitizenshipId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("new_dept_ind")]
    [StringLength(1)]
    public string? NewDeptInd { get; set; }

    [Column("visit_tracking_abrv")]
    [StringLength(2)]
    public string? VisitTrackingAbrv { get; set; }

    [Column("allergy_ind")]
    [StringLength(1)]
    public string? AllergyInd { get; set; }

    [Column("infection_ind")]
    [StringLength(1)]
    public string? InfectionInd { get; set; }

    [Column("directives_ind")]
    [StringLength(1)]
    public string? DirectivesInd { get; set; }

    [Column("copay_amt", TypeName = "numeric(8, 2)")]
    public decimal? CopayAmt { get; set; }

    [Column("pt_inpatient_ind")]
    [StringLength(1)]
    public string? PtInpatientInd { get; set; }

    [Column("pt_alert_ind")]
    [StringLength(1)]
    public string? PtAlertInd { get; set; }

    [Column("clin_trial_ind")]
    [StringLength(1)]
    public string? ClinTrialInd { get; set; }
}
