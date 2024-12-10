using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pln_typ")]
public partial class PlnTyp
{
    [Key]
    [Column("pln_typ")]
    public int PlnTyp1 { get; set; }

    [Column("pln_desc")]
    [StringLength(50)]
    public string PlnDesc { get; set; } = null!;

    [Column("product_use_typ")]
    public int? ProductUseTyp { get; set; }

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

    [InverseProperty("EvidenceLvlPlnTypNavigation")]
    public virtual ICollection<RgmSiteSeq> RgmSiteSeq { get; set; } = new List<RgmSiteSeq>();

    [InverseProperty("PlnTypNavigation")]
    public virtual ICollection<TxPln> TxPln { get; set; } = new List<TxPln>();
}
