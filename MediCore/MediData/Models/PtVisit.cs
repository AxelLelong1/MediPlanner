using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId")]
[Table("pt_visit")]
[Index("VisitInstId", "VisitStartTstamp", "VisitTyp", "VisitEndTstamp", Name = "nc10_pt_visit")]
[Index("DateTimeSch", Name = "nc1_pt_visit")]
[Index("VisitStartTstamp", Name = "nc2_pt_visit")]
[Index("PtId", "DateTpInit", "PhaseSeqNo", "CycleNo", "CycleDay", "RepeatNo", Name = "nc3_pt_visit")]
[Index("VisitInstId", "VisitStartTstamp", "PtId", "PtVisitId", "VisitTyp", "VisitEndTstamp", Name = "nc4_pt_visit")]
[Index("VisitInstId", "VisitStartTstamp", "PtId", "PtVisitId", "VisitTyp", "VisitEndTstamp", Name = "nc5_pt_visit")]
[Index("UseridLink", "InstId", "VisitInstId", "VisitTyp", Name = "nc6_pt_visit")]
[Index("PtId", "PtVisitId", "DateTimeSch", "TpName", "TpVersNo", "DateTpInit", Name = "nc7_pt_visit")]
[Index("VisitClinicId", "VisitInstId", "DateTimeSch", Name = "nc8_pt_visit")]
[Index("VisitInstId", "PtId", "PtVisitId", Name = "nc9_pt_visit")]
public partial class PtVisit
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("date_time_sch", TypeName = "datetime")]
    public DateTime? DateTimeSch { get; set; }

    [Column("visit_typ")]
    public int? VisitTyp { get; set; }

    [Column("visit_complete")]
    [StringLength(1)]
    public string? VisitComplete { get; set; }

    [Column("rx_sent", TypeName = "datetime")]
    public DateTime? RxSent { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("userid_link")]
    [StringLength(255)]
    public string? UseridLink { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("visit_imp_ind")]
    [StringLength(1)]
    public string? VisitImpInd { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("repeat_no")]
    public int? RepeatNo { get; set; }

    [Column("sch_end_tstamp", TypeName = "datetime")]
    public DateTime? SchEndTstamp { get; set; }

    [Column("visit_inst_id")]
    [StringLength(30)]
    public string? VisitInstId { get; set; }

    [Column("sch_cmt")]
    [StringLength(2000)]
    public string? SchCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("hl7_visit_id")]
    [StringLength(30)]
    public string? Hl7VisitId { get; set; }

    [Column("visit_start_tstamp", TypeName = "datetime")]
    public DateTime? VisitStartTstamp { get; set; }

    [Column("visit_end_tstamp", TypeName = "datetime")]
    public DateTime? VisitEndTstamp { get; set; }

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

    [Column("pt_arrive_ind")]
    [StringLength(1)]
    public string? PtArriveInd { get; set; }

    [Column("pt_cldr_id")]
    public int? PtCldrId { get; set; }

    [Column("pt_attend_ind")]
    [StringLength(1)]
    public string? PtAttendInd { get; set; }

    [Column("pt_visit_grp_id")]
    public int? PtVisitGrpId { get; set; }

    [Column("external_org_stkh_id")]
    [StringLength(20)]
    public string? ExternalOrgStkhId { get; set; }

    [Column("tentative_ind")]
    [StringLength(1)]
    public string? TentativeInd { get; set; }

    [Column("pt_instr_cmt")]
    [StringLength(255)]
    public string? PtInstrCmt { get; set; }

    [Column("visit_financial_status_typ")]
    public int? VisitFinancialStatusTyp { get; set; }

    [Column("visit_financial_status_cmt")]
    [StringLength(255)]
    public string? VisitFinancialStatusCmt { get; set; }

    [Column("new_dept_ind")]
    [StringLength(1)]
    public string? NewDeptInd { get; set; }

    [Column("visit_tracking_abrv")]
    [StringLength(2)]
    public string? VisitTrackingAbrv { get; set; }

    [InverseProperty("PtVisit")]
    public virtual ICollection<BillAcctPtVisit> BillAcctPtVisit { get; set; } = new List<BillAcctPtVisit>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<HcpRx> HcpRx { get; set; } = new List<HcpRx>();

    [ForeignKey("PtId")]
    [InverseProperty("PtVisit")]
    public virtual Pt Pt { get; set; } = null!;

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtAgendaStatus> PtAgendaStatus { get; set; } = new List<PtAgendaStatus>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtDxStatus> PtDxStatus { get; set; } = new List<PtDxStatus>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtInfoRequest> PtInfoRequest { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtIv> PtIv { get; set; } = new List<PtIv>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtOption> PtOption { get; set; } = new List<PtOption>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtRespHdr> PtRespHdr { get; set; } = new List<PtRespHdr>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<PtUnavl> PtUnavl { get; set; } = new List<PtUnavl>();

    [InverseProperty("PtVisit")]
    public virtual ICollection<TxVrtn> TxVrtn { get; set; } = new List<TxVrtn>();

    [ForeignKey("InstId, UseridLink")]
    [InverseProperty("PtVisit")]
    public virtual Userid? Userid { get; set; }

    [ForeignKey("PtId, VrblId")]
    [InverseProperty("PtVisit")]
    public virtual VrblOrder? VrblOrder { get; set; }
}
