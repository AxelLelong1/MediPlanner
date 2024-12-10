using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "StkhId")]
[Table("inst_stkh_erx")]
[Index("StkhId", Name = "nc1_inst_stkh_erx")]
public partial class InstStkhErx
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("erx_status_cd")]
    [StringLength(1)]
    public string? ErxStatusCd { get; set; }

    [Column("err_cd")]
    [StringLength(5)]
    public string? ErrCd { get; set; }

    [Column("err_desc")]
    [StringLength(255)]
    public string? ErrDesc { get; set; }

    [Column("service_lvl_code")]
    [StringLength(15)]
    public string? ServiceLvlCode { get; set; }

    [Column("service_lvl")]
    [StringLength(5)]
    public string? ServiceLvl { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

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

    [Column("epcs_status_cd")]
    [StringLength(3)]
    public string? EpcsStatusCd { get; set; }

    [Column("epcs_err_cd")]
    [StringLength(30)]
    public string? EpcsErrCd { get; set; }

    [Column("epcs_err_desc")]
    [StringLength(255)]
    public string? EpcsErrDesc { get; set; }
}
