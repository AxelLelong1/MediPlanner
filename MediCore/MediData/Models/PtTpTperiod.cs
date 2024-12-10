using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "PhaseSeqNo", "CycleNo", "TperiodId", "RepeatNo")]
[Table("pt_tp_tperiod")]
[Index("PtId", "PtVisitId", Name = "nc1_pt_tp_tperiod")]
[Index("PlnActionDate", Name = "nc2_pt_tp_tperiod")]
public partial class PtTpTperiod
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

    [Key]
    [Column("cycle_no")]
    public int CycleNo { get; set; }

    [Key]
    [Column("tperiod_id")]
    public int TperiodId { get; set; }

    [Key]
    [Column("repeat_no")]
    public int RepeatNo { get; set; }

    [Column("tperiod_desc")]
    [StringLength(255)]
    public string? TperiodDesc { get; set; }

    [Column("pln_action_date", TypeName = "datetime")]
    public DateTime? PlnActionDate { get; set; }

    [Column("date_action_taken", TypeName = "datetime")]
    public DateTime? DateActionTaken { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("applicable_ind")]
    [StringLength(1)]
    public string? ApplicableInd { get; set; }

    [Column("individualized_ind")]
    [StringLength(1)]
    public string? IndividualizedInd { get; set; }

    [Column("pt_interaction_id")]
    public int? PtInteractionId { get; set; }

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

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("std_cycle_no")]
    public int? StdCycleNo { get; set; }

    [Column("dose_rec_ind")]
    [StringLength(1)]
    public string? DoseRecInd { get; set; }

    [ForeignKey("PtInteractionId")]
    [InverseProperty("PtTpTperiod")]
    public virtual PtInteraction? PtInteraction { get; set; }

    [InverseProperty("PtTpTperiod")]
    public virtual ICollection<PtTpCycleAction> PtTpCycleAction { get; set; } = new List<PtTpCycleAction>();
}
