using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_config")]
public partial class ErxConfig
{
    [Key]
    [Column("erx_vendor")]
    [StringLength(10)]
    public string ErxVendor { get; set; } = null!;

    [Column("acct_id")]
    [StringLength(20)]
    public string? AcctId { get; set; }

    [Column("portal_id")]
    [StringLength(20)]
    public string? PortalId { get; set; }

    [Column("portal_id_bkup")]
    [StringLength(20)]
    public string? PortalIdBkup { get; set; }

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
}
