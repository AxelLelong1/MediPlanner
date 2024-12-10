using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimActivityTransactionMo
{
    [Column("DimDateID_AppointmentDateTime")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdAppointmentDateTime { get; set; } = null!;

    [Column("DimDateID_ActivityStartDateTime")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdActivityStartDateTime { get; set; } = null!;

    [Column("DimDateID_ActivityEndDateTime")]
    [StringLength(10)]
    [Unicode(false)]
    public string DimDateIdActivityEndDateTime { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDateTime { get; set; }

    public int? AppointmentStatus { get; set; }

    [Column("userid_link")]
    [StringLength(255)]
    public string? UseridLink { get; set; }

    [StringLength(20)]
    public string? TreatmentPlanName { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("visit_inst_id")]
    [StringLength(30)]
    public string? VisitInstId { get; set; }

    [StringLength(3000)]
    public string? ActivityNote { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityEndDateTime { get; set; }

    [Column("visit_clinic_id")]
    public int? VisitClinicId { get; set; }

    [Column("new_provider_ind")]
    [StringLength(1)]
    public string? NewProviderInd { get; set; }

    [Column("new_inst_ind")]
    [StringLength(1)]
    public string? NewInstInd { get; set; }

    [Column("cancel_reason_typ")]
    public int? CancelReasonTyp { get; set; }

    [StringLength(1)]
    public string? CheckedIn { get; set; }

    [Column("pt_attend_ind")]
    [StringLength(1)]
    public string? PtAttendInd { get; set; }

    [Column("tentative_ind")]
    [StringLength(1)]
    public string? TentativeInd { get; set; }

    [Column("visit_financial_status_cmt")]
    [StringLength(255)]
    public string? VisitFinancialStatusCmt { get; set; }

    [Column("new_dept_ind")]
    [StringLength(1)]
    public string? NewDeptInd { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Column("repeat_no")]
    public int? RepeatNo { get; set; }

    [Column("sch_end_tstamp", TypeName = "datetime")]
    public DateTime? SchEndTstamp { get; set; }

    public int IsVisitTypeOpenChart { get; set; }
}
