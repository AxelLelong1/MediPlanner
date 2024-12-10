using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "PhaseSeqNo")]
[Table("pt_tp_phase")]
public partial class PtTpPhase
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Column("phase_desc")]
    [StringLength(100)]
    public string PhaseDesc { get; set; } = null!;

    [Column("brief_desc")]
    public string? BriefDesc { get; set; }

    [Column("no_of_tperiods")]
    public int NoOfTperiods { get; set; }

    [Column("no_of_cycles")]
    public int NoOfCycles { get; set; }

    [Column("tperiod_dur")]
    public int? TperiodDur { get; set; }

    [Column("tperiod_dur_unit")]
    public int? TperiodDurUnit { get; set; }

    [Column("allowable_drift")]
    public int? AllowableDrift { get; set; }

    [Column("allowable_delay")]
    public int? AllowableDelay { get; set; }

    [Column("individualized_ind")]
    [StringLength(1)]
    public string? IndividualizedInd { get; set; }

    [Column("applicable_ind")]
    [StringLength(1)]
    public string? ApplicableInd { get; set; }

    [Column("lag_ind")]
    [StringLength(1)]
    public string? LagInd { get; set; }

    [Column("phase_start_tstamp", TypeName = "datetime")]
    public DateTime? PhaseStartTstamp { get; set; }

    [Column("phase_stop_tstamp", TypeName = "datetime")]
    public DateTime? PhaseStopTstamp { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("stop_vrbl_id")]
    public int? StopVrblId { get; set; }

    [Column("init_ht", TypeName = "numeric(11, 4)")]
    public decimal? InitHt { get; set; }

    [Column("ht_unit")]
    public int? HtUnit { get; set; }

    [Column("init_wt", TypeName = "numeric(11, 4)")]
    public decimal? InitWt { get; set; }

    [Column("wt_unit")]
    public int? WtUnit { get; set; }

    [Column("init_bsa", TypeName = "numeric(11, 4)")]
    public decimal? InitBsa { get; set; }

    [Column("cur_cycle")]
    public int? CurCycle { get; set; }

    [Column("pln_violated_flag")]
    [StringLength(1)]
    public string? PlnViolatedFlag { get; set; }

    [Column("cur_cycle_day")]
    public int? CurCycleDay { get; set; }

    [Column("next_cycle")]
    public int? NextCycle { get; set; }

    [Column("next_cycle_day")]
    public int? NextCycleDay { get; set; }

    [Column("consent_req")]
    [StringLength(1)]
    public string? ConsentReq { get; set; }

    [Column("updt_amended_tp")]
    [StringLength(1)]
    public string? UpdtAmendedTp { get; set; }

    [Column("tp_setup_ind")]
    [StringLength(1)]
    public string? TpSetupInd { get; set; }

    [Column("mgmt_support_ind")]
    [StringLength(1)]
    public string? MgmtSupportInd { get; set; }

    [Column("start_cycle")]
    public int? StartCycle { get; set; }

    [Column("start_day")]
    public int? StartDay { get; set; }

    [Column("mid_pln_ind")]
    [StringLength(1)]
    public string? MidPlnInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("prcs_typ")]
    public int? PrcsTyp { get; set; }

    [Column("tr_cs_req_ind")]
    [StringLength(1)]
    public string? TrCsReqInd { get; set; }

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

    [ForeignKey("PrcsTyp")]
    [InverseProperty("PtTpPhase")]
    public virtual PrcsTyp? PrcsTypNavigation { get; set; }

    [ForeignKey("PtId, DateTpInit")]
    [InverseProperty("PtTpPhase")]
    public virtual PtTp PtTp { get; set; } = null!;
}
