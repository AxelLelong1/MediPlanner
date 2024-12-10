using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("rx_typ")]
public partial class RxTyp
{
    [Key]
    [Column("rx_typ")]
    public int RxTyp1 { get; set; }

    [Column("rx_desc")]
    [StringLength(40)]
    public string RxDesc { get; set; } = null!;

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

    [InverseProperty("RxTypNavigation")]
    public virtual ICollection<HcpRxProd> HcpRxProd { get; set; } = new List<HcpRxProd>();

    [InverseProperty("RxTypNavigation")]
    public virtual ICollection<InstRxReport> InstRxReport { get; set; } = new List<InstRxReport>();

    [InverseProperty("RxTypNavigation")]
    public virtual ICollection<PtTpAgt> PtTpAgt { get; set; } = new List<PtTpAgt>();

    [InverseProperty("RxTypNavigation")]
    public virtual ICollection<Rx> Rx { get; set; } = new List<Rx>();

    [InverseProperty("RxTypNavigation")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();
}
