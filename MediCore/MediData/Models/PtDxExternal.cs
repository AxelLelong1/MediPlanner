using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtDxExternalId")]
[Table("pt_dx_external")]
public partial class PtDxExternal
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_dx_external_id")]
    public int PtDxExternalId { get; set; }

    [Column("snomed_ct_cd")]
    public long? SnomedCtCd { get; set; }

    [Column("clinical_desc")]
    [StringLength(255)]
    public string? ClinicalDesc { get; set; }

    [Column("dx_desc")]
    public string? DxDesc { get; set; }

    [Column("onset_date", TypeName = "datetime")]
    public DateTime? OnsetDate { get; set; }

    [Column("resolution_date", TypeName = "datetime")]
    public DateTime? ResolutionDate { get; set; }

    [Column("resolution_typ")]
    public int? ResolutionTyp { get; set; }

    [Column("prob_concern_act_status")]
    [StringLength(1)]
    public string? ProbConcernActStatus { get; set; }

    [Column("prob_observation_status")]
    [StringLength(1)]
    public string? ProbObservationStatus { get; set; }

    [Column("prob_observation_prob_typ")]
    public long? ProbObservationProbTyp { get; set; }

    [Column("prob_parsing_status")]
    [StringLength(1)]
    public string? ProbParsingStatus { get; set; }

    [Column("transition_of_care_inbound_id")]
    public int? TransitionOfCareInboundId { get; set; }

    [Column("recon_status")]
    [StringLength(1)]
    public string? ReconStatus { get; set; }

    [Column("recon_source_typ")]
    public int? ReconSourceTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("unique_ccda_id")]
    [StringLength(75)]
    public string? UniqueCcdaId { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtDxExternal")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("ReconSourceTyp")]
    [InverseProperty("PtDxExternal")]
    public virtual BaseTyp? ReconSourceTypNavigation { get; set; }

    [ForeignKey("ResolutionTyp")]
    [InverseProperty("PtDxExternal")]
    public virtual ResolutionTyp? ResolutionTypNavigation { get; set; }

    [ForeignKey("PtId, TransitionOfCareInboundId")]
    [InverseProperty("PtDxExternal")]
    public virtual TransitionOfCareInbound? TransitionOfCareInbound { get; set; }
}
