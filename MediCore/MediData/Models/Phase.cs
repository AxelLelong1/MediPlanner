using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo")]
[Table("phase")]
public partial class Phase
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Column("phase_desc")]
    [StringLength(100)]
    public string PhaseDesc { get; set; } = null!;

    [Column("no_of_cycles")]
    public int NoOfCycles { get; set; }

    [Column("allowable_drift")]
    public int? AllowableDrift { get; set; }

    [Column("allowable_delay")]
    public int? AllowableDelay { get; set; }

    [Column("tperiod_dur")]
    public int? TperiodDur { get; set; }

    [Column("tperiod_dur_unit")]
    public int? TperiodDurUnit { get; set; }

    [Column("length_of_cycle")]
    public int? LengthOfCycle { get; set; }

    [Column("brief_desc")]
    public string? BriefDesc { get; set; }

    [Column("lag_ind")]
    [StringLength(1)]
    public string? LagInd { get; set; }

    [Column("dow_start")]
    public int? DowStart { get; set; }

    [Column("prcs_typ")]
    public int? PrcsTyp { get; set; }

    [Column("tr_cs_req_ind")]
    [StringLength(1)]
    public string? TrCsReqInd { get; set; }

    [Column("admit_cls")]
    public int? AdmitCls { get; set; }

    [Column("modality")]
    public int? Modality { get; set; }

    [Column("max_no_cycle")]
    public int? MaxNoCycle { get; set; }

    [Column("max_dur")]
    public int? MaxDur { get; set; }

    [Column("max_dur_unit")]
    public int? MaxDurUnit { get; set; }

    [Column("phase_cls")]
    [StringLength(100)]
    public string? PhaseCls { get; set; }

    [Column("dur_desc")]
    [StringLength(50)]
    public string? DurDesc { get; set; }

    [Column("no_tx_days")]
    public int? NoTxDays { get; set; }

    [Column("no_clinic_visits")]
    public int? NoClinicVisits { get; set; }

    [Column("phase_sch_typ")]
    public int? PhaseSchTyp { get; set; }

    [Column("start_tperiod")]
    public int? StartTperiod { get; set; }

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

    [Column("expected_accrual_amt")]
    public int? ExpectedAccrualAmt { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("display_order")]
    public int? DisplayOrder { get; set; }

    [InverseProperty("Phase")]
    public virtual ICollection<PhaseTrRisk> PhaseTrRisk { get; set; } = new List<PhaseTrRisk>();

    [ForeignKey("PrcsTyp")]
    [InverseProperty("Phase")]
    public virtual PrcsTyp? PrcsTypNavigation { get; set; }

    [ForeignKey("TpName, TpVersNo")]
    [InverseProperty("Phase")]
    public virtual TxPln TxPln { get; set; } = null!;

    [InverseProperty("Phase")]
    public virtual ICollection<XrefTpRule> XrefTpRule { get; set; } = new List<XrefTpRule>();
}
