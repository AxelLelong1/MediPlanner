using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tr_cs_cert_typ")]
public partial class TrCsCertTyp
{
    [Key]
    [Column("tr_cs_cert_typ")]
    public int TrCsCertTyp1 { get; set; }

    [Column("tr_cs_cert_desc")]
    [StringLength(40)]
    public string TrCsCertDesc { get; set; } = null!;

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

    [InverseProperty("TrCsCertTypNavigation")]
    public virtual ICollection<TrAsmt> TrAsmt { get; set; } = new List<TrAsmt>();
}
