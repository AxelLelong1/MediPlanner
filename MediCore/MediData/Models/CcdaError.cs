using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ccda_error")]
public partial class CcdaError
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("ccda_error_id")]
    public int CcdaErrorId { get; set; }

    [Column("transition_of_care_inbound_id")]
    public int TransitionOfCareInboundId { get; set; }

    [Column("referral_date", TypeName = "datetime")]
    public DateTime ReferralDate { get; set; }

    [Column("ccda_filename")]
    [StringLength(64)]
    public string CcdaFilename { get; set; } = null!;

    [Column("error_location")]
    [StringLength(255)]
    public string? ErrorLocation { get; set; }

    [Column("error_description")]
    [StringLength(2000)]
    public string? ErrorDescription { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [ForeignKey("PtId, TransitionOfCareInboundId")]
    [InverseProperty("CcdaError")]
    public virtual TransitionOfCareInbound TransitionOfCareInbound { get; set; } = null!;
}
