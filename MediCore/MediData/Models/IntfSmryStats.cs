using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "PrcsStamp")]
[Table("intf_smry_stats")]
public partial class IntfSmryStats
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("msg_cnt")]
    public int? MsgCnt { get; set; }

    [Column("err_msg_cnt")]
    public int? ErrMsgCnt { get; set; }

    [Column("scss_msg_cnt")]
    public int? ScssMsgCnt { get; set; }

    [Column("wrng_msg_cnt")]
    public int? WrngMsgCnt { get; set; }

    [Column("prcs_hour")]
    public int? PrcsHour { get; set; }

    [Column("prcs_day")]
    public int? PrcsDay { get; set; }

    [Column("prcs_month")]
    public int? PrcsMonth { get; set; }

    [Column("prcs_year")]
    public int? PrcsYear { get; set; }

    [Key]
    [Column("prcs_stamp")]
    public int PrcsStamp { get; set; }

    [Column("prime_cnt")]
    public int? PrimeCnt { get; set; }

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

    [Column("filter_cnt")]
    public int? FilterCnt { get; set; }
}
