using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pharm_lib")]
[Index("State", Name = "nc1_pharm_lib")]
public partial class PharmLib
{
    [Key]
    [Column("ncpdpid")]
    [StringLength(7)]
    public string Ncpdpid { get; set; } = null!;

    [Column("store_no")]
    [StringLength(35)]
    public string? StoreNo { get; set; }

    [Column("ref_no_1")]
    [StringLength(35)]
    public string? RefNo1 { get; set; }

    [Column("ref_no_1_qual")]
    [StringLength(3)]
    public string? RefNo1Qual { get; set; }

    [Column("store_name")]
    [StringLength(35)]
    public string? StoreName { get; set; }

    [Column("addr1")]
    [StringLength(35)]
    public string? Addr1 { get; set; }

    [Column("addr2")]
    [StringLength(35)]
    public string? Addr2 { get; set; }

    [Column("city")]
    [StringLength(35)]
    public string? City { get; set; }

    [Column("state")]
    [StringLength(2)]
    public string? State { get; set; }

    [Column("zip_cd")]
    [StringLength(11)]
    public string? ZipCd { get; set; }

    [Column("phone_prmy")]
    [StringLength(25)]
    public string? PhonePrmy { get; set; }

    [Column("fax")]
    [StringLength(25)]
    public string? Fax { get; set; }

    [Column("email")]
    [StringLength(80)]
    public string? Email { get; set; }

    [Column("phone_alt1")]
    [StringLength(25)]
    public string? PhoneAlt1 { get; set; }

    [Column("phone_alt1_qual")]
    [StringLength(3)]
    public string? PhoneAlt1Qual { get; set; }

    [Column("phone_alt2")]
    [StringLength(25)]
    public string? PhoneAlt2 { get; set; }

    [Column("phone_alt2_qual")]
    [StringLength(3)]
    public string? PhoneAlt2Qual { get; set; }

    [Column("phone_alt3")]
    [StringLength(25)]
    public string? PhoneAlt3 { get; set; }

    [Column("phone_alt3_qual")]
    [StringLength(3)]
    public string? PhoneAlt3Qual { get; set; }

    [Column("phone_alt4")]
    [StringLength(25)]
    public string? PhoneAlt4 { get; set; }

    [Column("phone_alt4_qual")]
    [StringLength(3)]
    public string? PhoneAlt4Qual { get; set; }

    [Column("phone_alt5")]
    [StringLength(25)]
    public string? PhoneAlt5 { get; set; }

    [Column("phone_alt5_qual")]
    [StringLength(3)]
    public string? PhoneAlt5Qual { get; set; }

    [Column("active_start_dt", TypeName = "datetime")]
    public DateTime? ActiveStartDt { get; set; }

    [Column("active_end_dt", TypeName = "datetime")]
    public DateTime? ActiveEndDt { get; set; }

    [Column("srvc_lvl")]
    public int? SrvcLvl { get; set; }

    [Column("partner_acct")]
    [StringLength(35)]
    public string? PartnerAcct { get; set; }

    [Column("last_mod_dt")]
    [StringLength(22)]
    public string? LastModDt { get; set; }

    [Column("open24hr_cd")]
    [StringLength(1)]
    public string? Open24hrCd { get; set; }

    [Column("cross_st")]
    [StringLength(35)]
    public string? CrossSt { get; set; }

    [Column("old_srvc_lvl")]
    [StringLength(5)]
    public string? OldSrvcLvl { get; set; }

    [Column("srvc_lvl_txt")]
    [StringLength(100)]
    public string? SrvcLvlTxt { get; set; }

    [Column("srvc_lvl_txt_chg")]
    [StringLength(100)]
    public string? SrvcLvlTxtChg { get; set; }

    [Column("version")]
    [StringLength(5)]
    public string? Version { get; set; }

    [Column("npi")]
    [StringLength(10)]
    public string? Npi { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("store_name_upper")]
    [StringLength(35)]
    public string? StoreNameUpper { get; set; }

    [Column("addr1_upper")]
    [StringLength(35)]
    public string? Addr1Upper { get; set; }

    [Column("city_upper")]
    [StringLength(35)]
    public string? CityUpper { get; set; }

    [Column("pharm_typ")]
    [StringLength(1)]
    public string? PharmTyp { get; set; }

    [Column("pharm_spec_cd")]
    public int? PharmSpecCd { get; set; }
}
