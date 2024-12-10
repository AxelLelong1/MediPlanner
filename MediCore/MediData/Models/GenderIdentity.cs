using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("gender_identity")]
public partial class GenderIdentity
{
    [Key]
    [Column("gender_identity_id")]
    public int GenderIdentityId { get; set; }

    [Column("gender_identity_desc")]
    [StringLength(64)]
    public string GenderIdentityDesc { get; set; } = null!;

    [Column("gender_identity_cd")]
    [StringLength(20)]
    public string? GenderIdentityCd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("default_ind")]
    [StringLength(1)]
    public string? DefaultInd { get; set; }

    [Column("free_text_ind")]
    [StringLength(1)]
    public string? FreeTextInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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
}
