using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfTrgrSeqNo")]
[Table("intf_app_parm_trgr")]
[Index("ProcessInd", Name = "nc1_intf_app_parm_trgr")]
[Index("IntfTrgrSeqNo", Name = "nc2_intf_app_parm_trgr")]
public partial class IntfAppParmTrgr
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_trgr_seq_no")]
    public int IntfTrgrSeqNo { get; set; }

    [Column("process_ind")]
    [StringLength(1)]
    public string ProcessInd { get; set; } = null!;

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

    [Column("hl7_out_seq_no")]
    public int? Hl7OutSeqNo { get; set; }

    [Column("prcs_attempt_cnt")]
    public int PrcsAttemptCnt { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmTrgr")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [ForeignKey("IntfTrgrSeqNo")]
    [InverseProperty("IntfAppParmTrgr")]
    public virtual IntfTrgr IntfTrgrSeqNoNavigation { get; set; } = null!;
}
