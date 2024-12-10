using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TransitionOfCareOutboundId")]
[Table("transition_of_care_outbound")]
public partial class TransitionOfCareOutbound
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("transition_of_care_outbound_id")]
    public int TransitionOfCareOutboundId { get; set; }

    [Column("referral_date", TypeName = "datetime")]
    public DateTime ReferralDate { get; set; }

    [Column("referred_by_stkh_id")]
    [StringLength(20)]
    public string? ReferredByStkhId { get; set; }

    [Column("receiving_provider_stkh_id")]
    [StringLength(20)]
    public string? ReceivingProviderStkhId { get; set; }

    [Column("receiving_resource_ser")]
    public long? ReceivingResourceSer { get; set; }

    [Column("receiving_external_name")]
    [StringLength(255)]
    public string? ReceivingExternalName { get; set; }

    [Column("delivery_method_typ")]
    public int? DeliveryMethodTyp { get; set; }

    [Column("message_id")]
    public int? MessageId { get; set; }

    [Column("reason_for_referral")]
    [StringLength(255)]
    public string? ReasonForReferral { get; set; }

    [Column("ccda_provided_ind")]
    [StringLength(1)]
    public string? CcdaProvidedInd { get; set; }

    [Column("ccda_start_date", TypeName = "datetime")]
    public DateTime? CcdaStartDate { get; set; }

    [Column("ccda_end_date", TypeName = "datetime")]
    public DateTime? CcdaEndDate { get; set; }

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

    [Column("document_typ")]
    public int? DocumentTyp { get; set; }

    [Column("secure_hash")]
    [MaxLength(32)]
    public byte[]? SecureHash { get; set; }

    public long? HospitalSer { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
