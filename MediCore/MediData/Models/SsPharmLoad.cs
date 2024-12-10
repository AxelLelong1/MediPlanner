using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ss_pharm_load")]
public partial class SsPharmLoad
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

    [Column("phone_1")]
    [StringLength(25)]
    public string? Phone1 { get; set; }

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

    [Column("active_start_dt")]
    [StringLength(22)]
    public string? ActiveStartDt { get; set; }

    [Column("active_end_dt")]
    [StringLength(22)]
    public string? ActiveEndDt { get; set; }

    [Column("srvc_lvl")]
    [StringLength(5)]
    public string? SrvcLvl { get; set; }

    [Column("partner_acct")]
    [StringLength(35)]
    public string? PartnerAcct { get; set; }

    [Column("last_mod_dt")]
    [StringLength(22)]
    public string? LastModDt { get; set; }

    [Column("open24hr_flag")]
    [StringLength(1)]
    public string? Open24hrFlag { get; set; }

    [Column("cross_st")]
    [StringLength(35)]
    public string? CrossSt { get; set; }

    [Column("rec_chg")]
    [StringLength(1)]
    public string? RecChg { get; set; }

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

    [Column("pharm_typ")]
    [StringLength(1)]
    public string? PharmTyp { get; set; }

    [Column("pharm_spec_cd")]
    public int? PharmSpecCd { get; set; }
}
