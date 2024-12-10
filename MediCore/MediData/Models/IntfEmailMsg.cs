using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_email_msg")]
public partial class IntfEmailMsg
{
    [Key]
    [Column("intf_email_msg_id")]
    [StringLength(10)]
    public string IntfEmailMsgId { get; set; } = null!;

    [Column("intf_email_id")]
    public int IntfEmailId { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("seg_typ_id")]
    [StringLength(10)]
    public string SegTypId { get; set; } = null!;

    [Column("msg_no")]
    [StringLength(10)]
    public string MsgNo { get; set; } = null!;

    [Column("lang_typ")]
    public int? LangTyp { get; set; }

    [Column("severity")]
    public int? Severity { get; set; }

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

    [ForeignKey("IntfEmailId")]
    [InverseProperty("IntfEmailMsg")]
    public virtual IntfEmail IntfEmail { get; set; } = null!;
}
