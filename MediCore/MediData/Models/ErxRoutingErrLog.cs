using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_routing_err_log")]
public partial class ErxRoutingErrLog
{
    [Key]
    [Column("erx_routing_err_log_id")]
    public int ErxRoutingErrLogId { get; set; }

    [Column("edi_out_id")]
    public int EdiOutId { get; set; }

    [Column("failed_message")]
    public string? FailedMessage { get; set; }

    [Column("err_code")]
    public int? ErrCode { get; set; }

    [Column("err_desc")]
    [StringLength(255)]
    public string? ErrDesc { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }
}
