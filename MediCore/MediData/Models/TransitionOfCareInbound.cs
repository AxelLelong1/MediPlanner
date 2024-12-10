using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TransitionOfCareInboundId")]
[Table("transition_of_care_inbound")]
public partial class TransitionOfCareInbound
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("transition_of_care_inbound_id")]
    public int TransitionOfCareInboundId { get; set; }

    [Column("inbound_source_typ")]
    public int InboundSourceTyp { get; set; }

    [Column("message_id")]
    public int? MessageId { get; set; }

    [Column("referral_date", TypeName = "datetime")]
    public DateTime ReferralDate { get; set; }

    [Column("referred_by_stkh_id")]
    [StringLength(20)]
    public string? ReferredByStkhId { get; set; }

    [Column("referred_by_resource_ser")]
    public long? ReferredByResourceSer { get; set; }

    [Column("referred_by_external_name")]
    [StringLength(255)]
    public string? ReferredByExternalName { get; set; }

    [Column("receiving_provider_stkh_id")]
    [StringLength(20)]
    public string ReceivingProviderStkhId { get; set; } = null!;

    [Column("encounter_typ")]
    public int EncounterTyp { get; set; }

    [Column("medications_reconciled_ind")]
    [StringLength(1)]
    public string? MedicationsReconciledInd { get; set; }

    [Column("doc_file_loc")]
    [StringLength(255)]
    public string? DocFileLoc { get; set; }

    [Column("img_dcmnt_id")]
    [StringLength(14)]
    public string? ImgDcmntId { get; set; }

    [Column("ccda_filename")]
    [StringLength(255)]
    public string? CcdaFilename { get; set; }

    [Column("approved_ind")]
    [StringLength(1)]
    public string ApprovedInd { get; set; } = null!;

    [Column("approved_by_userid")]
    [StringLength(255)]
    public string? ApprovedByUserid { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("interface_ind")]
    [StringLength(1)]
    public string? InterfaceInd { get; set; }

    [Column("secure_hash")]
    [MaxLength(32)]
    public byte[]? SecureHash { get; set; }

    [Column("allergies_reconciled_ind")]
    [StringLength(1)]
    public string? AllergiesReconciledInd { get; set; }

    [Column("problems_reconciled_ind")]
    [StringLength(1)]
    public string? ProblemsReconciledInd { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    public long? HospitalSer { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("medications_reconciled_date", TypeName = "datetime")]
    public DateTime? MedicationsReconciledDate { get; set; }

    [InverseProperty("TransitionOfCareInbound")]
    public virtual ICollection<CcdaError> CcdaError { get; set; } = new List<CcdaError>();

    [InverseProperty("TransitionOfCareInbound")]
    public virtual ICollection<PtAllergyExternal> PtAllergyExternal { get; set; } = new List<PtAllergyExternal>();

    [InverseProperty("TransitionOfCareInbound")]
    public virtual ICollection<PtDxExternal> PtDxExternal { get; set; } = new List<PtDxExternal>();

    [InverseProperty("TransitionOfCareInbound")]
    public virtual ICollection<XrefAgtPtExternal> XrefAgtPtExternal { get; set; } = new List<XrefAgtPtExternal>();
}
