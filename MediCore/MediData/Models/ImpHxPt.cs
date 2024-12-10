using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SeqNo", "PtId")]
[Table("imp_hx_pt")]
[Index("PtId", Name = "nc1_imp_hx_pt")]
public partial class ImpHxPt
{
    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("imp_typ")]
    [StringLength(1)]
    public string ImpTyp { get; set; } = null!;

    [Column("imp_vers_no")]
    public int ImpVersNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("SeqNo")]
    [InverseProperty("ImpHxPt")]
    public virtual ImpHxMast SeqNoNavigation { get; set; } = null!;
}
