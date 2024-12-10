using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dcmnt_server")]
public partial class DcmntServer
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("fax_port")]
    public int? FaxPort { get; set; }

    [Column("fax_login_userid")]
    [StringLength(255)]
    public string? FaxLoginUserid { get; set; }

    [Column("fax_server_name")]
    [StringLength(30)]
    public string? FaxServerName { get; set; }

    [Column("fax_login_password")]
    [StringLength(30)]
    public string? FaxLoginPassword { get; set; }

    [Column("fax_dialing_prefix")]
    [StringLength(30)]
    public string? FaxDialingPrefix { get; set; }

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

    [Column("intf_engine_id")]
    [StringLength(10)]
    public string? IntfEngineId { get; set; }

    [Column("fax_comm_protocol")]
    [StringLength(40)]
    public string? FaxCommProtocol { get; set; }

    [Column("coversheet_req_ind")]
    [StringLength(1)]
    public string? CoversheetReqInd { get; set; }

    [Column("coversheet_path")]
    [StringLength(255)]
    public string? CoversheetPath { get; set; }

    [Column("fax_product_id")]
    public int? FaxProductId { get; set; }
}
