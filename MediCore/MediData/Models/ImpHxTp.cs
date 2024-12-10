using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SeqNo", "TpExpName", "TpExpVersNo")]
[Table("imp_hx_tp")]
public partial class ImpHxTp
{
    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Key]
    [Column("tp_exp_name")]
    [StringLength(20)]
    public string TpExpName { get; set; } = null!;

    [Column("tp_new_name")]
    [StringLength(20)]
    public string? TpNewName { get; set; }

    [Column("tp_amended_flag")]
    [StringLength(1)]
    public string TpAmendedFlag { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Key]
    [Column("tp_exp_vers_no")]
    [StringLength(10)]
    public string TpExpVersNo { get; set; } = null!;

    [ForeignKey("SeqNo")]
    [InverseProperty("ImpHxTp")]
    public virtual ImpHxMast SeqNoNavigation { get; set; } = null!;
}
