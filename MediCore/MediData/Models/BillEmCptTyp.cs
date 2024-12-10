using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_em_cpt_typ")]
public partial class BillEmCptTyp
{
    [Key]
    [Column("bill_em_cpt_typ")]
    public int BillEmCptTyp1 { get; set; }

    [Column("bill_em_cpt_desc")]
    [StringLength(50)]
    public string BillEmCptDesc { get; set; } = null!;

    [Column("bill_em_cpt_reqd")]
    public int BillEmCptReqd { get; set; }

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

    [InverseProperty("BillEmCptTypNavigation")]
    public virtual ICollection<XrefTestCompCpt> XrefTestCompCpt { get; set; } = new List<XrefTestCompCpt>();
}
