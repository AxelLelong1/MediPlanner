using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StkhId", "StkhPhoneId")]
[Table("stkh_phone")]
public partial class StkhPhone
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("stkh_phone_id")]
    public int StkhPhoneId { get; set; }

    [Column("phone_cd")]
    [StringLength(2)]
    public string PhoneCd { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("phone_no")]
    [StringLength(28)]
    public string? PhoneNo { get; set; }

    [Column("ext_no")]
    [StringLength(10)]
    public string? ExtNo { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("end_reason_cd")]
    [StringLength(3)]
    public string? EndReasonCd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [Column("stkh_stkh_id")]
    [StringLength(14)]
    public string? StkhStkhId { get; set; }

    [Column("phone_no_fmt_id")]
    public int? PhoneNoFmtId { get; set; }

    [ForeignKey("PhoneCd, StkhCd")]
    [InverseProperty("StkhPhone")]
    public virtual PhoneCd PhoneCdNavigation { get; set; } = null!;

    [ForeignKey("PhoneNoFmtId")]
    [InverseProperty("StkhPhone")]
    public virtual FmtField? PhoneNoFmt { get; set; }

    [ForeignKey("StkhId")]
    [InverseProperty("StkhPhone")]
    public virtual Stkh Stkh { get; set; } = null!;
}
