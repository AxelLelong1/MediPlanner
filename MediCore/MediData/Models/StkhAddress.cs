using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StkhId", "StkhAddressId")]
[Table("stkh_address")]
public partial class StkhAddress
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("stkh_address_id")]
    public int StkhAddressId { get; set; }

    [Column("address_cd")]
    [StringLength(2)]
    public string AddressCd { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("address_1")]
    [StringLength(30)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(30)]
    public string? Address2 { get; set; }

    [Column("address_3")]
    [StringLength(30)]
    public string? Address3 { get; set; }

    [Column("city")]
    [StringLength(30)]
    public string? City { get; set; }

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("pc_zip")]
    [StringLength(10)]
    public string? PcZip { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("county")]
    [StringLength(30)]
    public string? County { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime EndDate { get; set; }

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

    [Column("prv_state")]
    [StringLength(30)]
    public string? PrvState { get; set; }

    [Column("pc_zip_fmt_id")]
    public int? PcZipFmtId { get; set; }

    [ForeignKey("AddressCd, StkhCd")]
    [InverseProperty("StkhAddress")]
    public virtual AddressCd AddressCdNavigation { get; set; } = null!;

    [ForeignKey("PcZipFmtId")]
    [InverseProperty("StkhAddress")]
    public virtual FmtField? PcZipFmt { get; set; }

    [ForeignKey("StkhId")]
    [InverseProperty("StkhAddress")]
    public virtual Stkh Stkh { get; set; } = null!;
}
