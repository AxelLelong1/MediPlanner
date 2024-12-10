using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AllergyId")]
[Table("pt_allergy")]
public partial class PtAllergy
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("allergy_id")]
    public int AllergyId { get; set; }

    [Column("allergy_typ")]
    public int AllergyTyp { get; set; }

    [Column("valid_entry")]
    [StringLength(1)]
    public string? ValidEntry { get; set; }

    [Column("resp")]
    public string? Resp { get; set; }

    [Column("allergy_desc")]
    public string? AllergyDesc { get; set; }

    [Column("severity_id")]
    public int? SeverityId { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string? DrugDescId { get; set; }

    [Column("kdc")]
    [StringLength(10)]
    public string? Kdc { get; set; }

    [Column("date_approx_ind")]
    [StringLength(1)]
    public string? DateApproxInd { get; set; }

    [Column("onset_date", TypeName = "datetime")]
    public DateTime? OnsetDate { get; set; }

    [Column("onset_date_cd")]
    public int? OnsetDateCd { get; set; }

    [Column("reaction_cd")]
    [StringLength(1)]
    public string? ReactionCd { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("admn_id")]
    public int? AdmnId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string? AgtName { get; set; }

    [Column("par_id")]
    public int? ParId { get; set; }

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [Column("allergy_cmt")]
    [StringLength(255)]
    public string? AllergyCmt { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("unique_ccda_id")]
    [StringLength(75)]
    public string? UniqueCcdaId { get; set; }

    [Column("intf_reconcile_date", TypeName = "datetime")]
    public DateTime? IntfReconcileDate { get; set; }

    [ForeignKey("AllergyTyp")]
    [InverseProperty("PtAllergy")]
    public virtual AllergyTyp AllergyTypNavigation { get; set; } = null!;

    [ForeignKey("OnsetDateCd")]
    [InverseProperty("PtAllergy")]
    public virtual DateCd? OnsetDateCdNavigation { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtAllergy")]
    public virtual Pt Pt { get; set; } = null!;

    [InverseProperty("PtAllergy")]
    public virtual ICollection<PtAllergyResp> PtAllergyResp { get; set; } = new List<PtAllergyResp>();

    [ForeignKey("SeverityId")]
    [InverseProperty("PtAllergy")]
    public virtual AllergySeverity? Severity { get; set; }
}
