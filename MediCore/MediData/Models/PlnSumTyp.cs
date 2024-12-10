using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pln_sum_typ")]
public partial class PlnSumTyp
{
    [Key]
    [Column("pln_sum_typ")]
    public int PlnSumTyp1 { get; set; }

    [Column("pln_sum_desc")]
    [StringLength(30)]
    public string PlnSumDesc { get; set; } = null!;

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

    [Column("pln_sum_typ_seq")]
    public int? PlnSumTypSeq { get; set; }

    [InverseProperty("PlnSumTypNavigation")]
    public virtual ICollection<TpSum> TpSum { get; set; } = new List<TpSum>();
}
