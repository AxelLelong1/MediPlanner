using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_em_elmt_typ")]
public partial class BillEmElmtTyp
{
    [Key]
    [Column("bill_em_elmt_typ")]
    public int BillEmElmtTyp1 { get; set; }

    [Column("bill_em_elmt_desc")]
    [StringLength(40)]
    public string BillEmElmtDesc { get; set; } = null!;

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

    [InverseProperty("BillEmElmtTypNavigation")]
    public virtual ICollection<BillEmDefn> BillEmDefn { get; set; } = new List<BillEmDefn>();
}
