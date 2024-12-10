using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtConsentId")]
[Table("pt_consent")]
public partial class PtConsent
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_consent_id")]
    public int PtConsentId { get; set; }

    [Column("pt_consent_typ")]
    public int PtConsentTyp { get; set; }

    [Column("pt_consent_start_tstamp", TypeName = "datetime")]
    public DateTime? PtConsentStartTstamp { get; set; }

    [Column("pt_consent_end_tstamp", TypeName = "datetime")]
    public DateTime? PtConsentEndTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string CurEntryInd { get; set; } = null!;

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_consent_cd")]
    [StringLength(1)]
    public string PtConsentCd { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtConsent")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("PtConsentTyp")]
    [InverseProperty("PtConsent")]
    public virtual BaseTyp PtConsentTypNavigation { get; set; } = null!;
}
