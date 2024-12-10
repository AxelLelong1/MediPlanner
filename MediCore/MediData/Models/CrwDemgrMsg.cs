using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTimeSch")]
[Table("crw_demgr_msg")]
public partial class CrwDemgrMsg
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_time_sch", TypeName = "datetime")]
    public DateTime DateTimeSch { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string? Userid { get; set; }

    [Column("session_id")]
    [StringLength(25)]
    public string? SessionId { get; set; }

    [Column("job_no")]
    public int? JobNo { get; set; }

    [Column("str_1")]
    [StringLength(50)]
    public string? Str1 { get; set; }

    [Column("dt_1", TypeName = "datetime")]
    public DateTime? Dt1 { get; set; }

    [Column("dt_2", TypeName = "datetime")]
    public DateTime? Dt2 { get; set; }

    [Column("hdr_1")]
    [StringLength(255)]
    public string? Hdr1 { get; set; }

    [Column("ssn_demo_ind")]
    [StringLength(1)]
    public string? SsnDemoInd { get; set; }

    [Column("address_ind")]
    [StringLength(1)]
    public string? AddressInd { get; set; }

    [Column("city_ind")]
    [StringLength(1)]
    public string? CityInd { get; set; }

    [Column("county_ind")]
    [StringLength(1)]
    public string? CountyInd { get; set; }

    [Column("state_ind")]
    [StringLength(1)]
    public string? StateInd { get; set; }

    [Column("country_ind")]
    [StringLength(1)]
    public string? CountryInd { get; set; }

    [Column("zip_ind")]
    [StringLength(1)]
    public string? ZipInd { get; set; }

    [Column("home_tel_ind")]
    [StringLength(1)]
    public string? HomeTelInd { get; set; }

    [Column("bus_tel_ind")]
    [StringLength(1)]
    public string? BusTelInd { get; set; }

    [Column("pic_ind")]
    [StringLength(1)]
    public string? PicInd { get; set; }

    [Column("provider_ind")]
    [StringLength(1)]
    public string? ProviderInd { get; set; }

    [Column("referring_ind")]
    [StringLength(1)]
    public string? ReferringInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
