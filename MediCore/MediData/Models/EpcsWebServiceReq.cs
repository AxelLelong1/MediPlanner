using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("epcs_web_service_req")]
[Index("WebServiceName", "ReqDt", Name = "nc1_epcs_web_service_req")]
public partial class EpcsWebServiceReq
{
    [Key]
    [Column("epcs_web_service_req_id")]
    public int EpcsWebServiceReqId { get; set; }

    [Column("web_service_name")]
    [StringLength(100)]
    public string WebServiceName { get; set; } = null!;

    [Column("req_dt", TypeName = "datetime")]
    public DateTime ReqDt { get; set; }

    [Column("req_inst_id")]
    [StringLength(30)]
    public string? ReqInstId { get; set; }

    [Column("req_userid")]
    [StringLength(255)]
    public string? ReqUserid { get; set; }

    [Column("req_user_inst_id")]
    [StringLength(30)]
    public string? ReqUserInstId { get; set; }

    [Column("req_xml")]
    public string? ReqXml { get; set; }

    [Column("resp_xml")]
    public string? RespXml { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
