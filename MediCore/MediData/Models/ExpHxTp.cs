using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SeqNo", "TpName", "TpVersNo")]
[Table("exp_hx_tp")]
public partial class ExpHxTp
{
    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("tp_typ")]
    [StringLength(1)]
    public string TpTyp { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("SeqNo")]
    [InverseProperty("ExpHxTp")]
    public virtual ExpHxMast SeqNoNavigation { get; set; } = null!;
}
