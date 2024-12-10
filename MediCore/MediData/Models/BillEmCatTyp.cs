using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_em_cat_typ")]
public partial class BillEmCatTyp
{
    [Key]
    [Column("bill_em_cat_typ")]
    public int BillEmCatTyp1 { get; set; }

    [Column("bill_em_cat_desc")]
    [StringLength(80)]
    public string BillEmCatDesc { get; set; } = null!;

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

    [InverseProperty("BillEmCatTypNavigation")]
    public virtual ICollection<BillEmDefn> BillEmDefn { get; set; } = new List<BillEmDefn>();

    [InverseProperty("BillEmCatTypNavigation")]
    public virtual ICollection<BillEventEmInfo> BillEventEmInfo { get; set; } = new List<BillEventEmInfo>();
}
