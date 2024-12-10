using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfMode", "MsgTyp")]
[Table("intf_mode_msg_typ")]
public partial class IntfModeMsgTyp
{
    [Key]
    [Column("intf_mode")]
    public int IntfMode { get; set; }

    [Key]
    [Column("msg_typ")]
    [StringLength(3)]
    public string MsgTyp { get; set; } = null!;

    [Column("direction_ind")]
    [StringLength(1)]
    public string DirectionInd { get; set; } = null!;

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
