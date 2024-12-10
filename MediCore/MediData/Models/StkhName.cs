using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StkhId", "StkhNameId")]
[Table("stkh_name")]
[Index("UpperName", Name = "nc1_stkh_name")]
public partial class StkhName
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("stkh_name_id")]
    public int StkhNameId { get; set; }

    [Column("name_cd")]
    [StringLength(1)]
    public string NameCd { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("first_name")]
    [StringLength(30)]
    public string? FirstName { get; set; }

    [Column("initial")]
    [StringLength(2)]
    public string? Initial { get; set; }

    [Column("last_name")]
    [StringLength(30)]
    public string? LastName { get; set; }

    [Column("title_typ")]
    public int? TitleTyp { get; set; }

    [Column("org_name")]
    [StringLength(40)]
    public string? OrgName { get; set; }

    [Column("upper_name")]
    [StringLength(40)]
    public string? UpperName { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [Column("end_reason_cd")]
    [StringLength(3)]
    public string? EndReasonCd { get; set; }

    [Column("pref_ind")]
    [StringLength(1)]
    public string PrefInd { get; set; } = null!;

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("upper_first_name")]
    [StringLength(30)]
    public string? UpperFirstName { get; set; }

    [Column("dsp_name")]
    [StringLength(80)]
    public string? DspName { get; set; }

    [ForeignKey("NameCd, StkhCd")]
    [InverseProperty("StkhName")]
    public virtual NameCd NameCdNavigation { get; set; } = null!;

    [ForeignKey("StkhId")]
    [InverseProperty("StkhName")]
    public virtual Stkh Stkh { get; set; } = null!;
}
