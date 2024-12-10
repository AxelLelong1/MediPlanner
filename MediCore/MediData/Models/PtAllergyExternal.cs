using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAllergyExternalId")]
[Table("pt_allergy_external")]
public partial class PtAllergyExternal
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_allergy_external_id")]
    public int PtAllergyExternalId { get; set; }

    [Column("allergy_typ")]
    public int? AllergyTyp { get; set; }

    [Column("allergy_prob_act_status")]
    [StringLength(1)]
    public string? AllergyProbActStatus { get; set; }

    [Column("allergy_observation_status")]
    [StringLength(1)]
    public string? AllergyObservationStatus { get; set; }

    [Column("allergy_desc")]
    public string? AllergyDesc { get; set; }

    [Column("resp_txt")]
    public string? RespTxt { get; set; }

    [Column("onset_date", TypeName = "datetime")]
    public DateTime? OnsetDate { get; set; }

    [Column("reaction_cd")]
    [StringLength(1)]
    public string? ReactionCd { get; set; }

    [Column("rxnorm_id")]
    [StringLength(30)]
    public string? RxnormId { get; set; }

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string? DrugDescId { get; set; }

    [Column("kdc")]
    [StringLength(10)]
    public string? Kdc { get; set; }

    [Column("recon_status")]
    [StringLength(1)]
    public string? ReconStatus { get; set; }

    [Column("recon_source_typ")]
    public int? ReconSourceTyp { get; set; }

    [Column("allergy_parsing_status")]
    [StringLength(1)]
    public string? AllergyParsingStatus { get; set; }

    [Column("allergy_resp_parsing_status")]
    [StringLength(1)]
    public string? AllergyRespParsingStatus { get; set; }

    [Column("transition_of_care_inbound_id")]
    public int? TransitionOfCareInboundId { get; set; }

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

    [Column("unique_ccda_id")]
    [StringLength(75)]
    public string? UniqueCcdaId { get; set; }

    [ForeignKey("AllergyTyp")]
    [InverseProperty("PtAllergyExternal")]
    public virtual AllergyTyp? AllergyTypNavigation { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtAllergyExternal")]
    public virtual Pt Pt { get; set; } = null!;

    [InverseProperty("PtAllergyExternal")]
    public virtual ICollection<PtAllergyRespExternal> PtAllergyRespExternal { get; set; } = new List<PtAllergyRespExternal>();

    [ForeignKey("ReconSourceTyp")]
    [InverseProperty("PtAllergyExternal")]
    public virtual BaseTyp? ReconSourceTypNavigation { get; set; }

    [ForeignKey("PtId, TransitionOfCareInboundId")]
    [InverseProperty("PtAllergyExternal")]
    public virtual TransitionOfCareInbound? TransitionOfCareInbound { get; set; }
}
