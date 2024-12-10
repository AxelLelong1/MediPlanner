using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ext_drug_db_fdb_detail")]
public partial class ExtDrugDbFdbDetail
{
    [Key]
    [Column("ext_drug_db_id")]
    public int ExtDrugDbId { get; set; }

    [Column("region_code")]
    public int? RegionCode { get; set; }

    [Column("language_id")]
    public int? LanguageId { get; set; }

    [Column("short_name")]
    [StringLength(60)]
    public string ShortName { get; set; } = null!;

    [Column("abbrev")]
    [StringLength(10)]
    public string Abbrev { get; set; } = null!;

    [Column("fdb_server_name")]
    [StringLength(100)]
    public string FdbServerName { get; set; } = null!;

    [Column("fdb_database_name")]
    [StringLength(100)]
    public string FdbDatabaseName { get; set; } = null!;

    [Column("fdb_userid")]
    [StringLength(255)]
    public string FdbUserid { get; set; } = null!;

    [Column("fdb_password")]
    [StringLength(20)]
    public string FdbPassword { get; set; } = null!;

    [Column("disclaimer_msg_txt")]
    public string? DisclaimerMsgTxt { get; set; }

    [Column("licence_agrmt_txt")]
    public string? LicenceAgrmtTxt { get; set; }

    [Column("dll_name")]
    [StringLength(80)]
    public string DllName { get; set; } = null!;

    [Column("logo1_pic")]
    [StringLength(100)]
    public string? Logo1Pic { get; set; }

    [Column("logo2_pic")]
    [StringLength(100)]
    public string? Logo2Pic { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
