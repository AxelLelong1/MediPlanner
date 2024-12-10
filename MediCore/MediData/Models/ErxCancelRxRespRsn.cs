using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "ErxCancelRxRespRsnId")]
[Table("erx_cancel_rx_resp_rsn")]
public partial class ErxCancelRxRespRsn
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("erx_cancel_rx_resp_rsn_id")]
    public int ErxCancelRxRespRsnId { get; set; }

    [Column("erx_cancel_rx_id")]
    public int ErxCancelRxId { get; set; }

    [Column("resp_rsn_cd")]
    [StringLength(2)]
    public string RespRsnCd { get; set; } = null!;

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

    [ForeignKey("PtId, ErxCancelRxId")]
    [InverseProperty("ErxCancelRxRespRsn")]
    public virtual ErxCancelRx ErxCancelRx { get; set; } = null!;
}
