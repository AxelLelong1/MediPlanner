using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfTrgrSeqNo", "TrgrKeyName")]
[Table("intf_trgr_keys")]
public partial class IntfTrgrKeys
{
    [Key]
    [Column("intf_trgr_seq_no")]
    public int IntfTrgrSeqNo { get; set; }

    [Key]
    [Column("trgr_key_name")]
    [StringLength(60)]
    public string TrgrKeyName { get; set; } = null!;

    [Column("trgr_key_val")]
    [StringLength(255)]
    public string? TrgrKeyVal { get; set; }

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

    [ForeignKey("IntfTrgrSeqNo")]
    [InverseProperty("IntfTrgrKeys")]
    public virtual IntfTrgr IntfTrgrSeqNoNavigation { get; set; } = null!;
}
