using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hcp_typ")]
public partial class HcpTyp
{
    [Key]
    [Column("hcp_typ")]
    public int HcpTyp1 { get; set; }

    [Column("hcp_typ_desc")]
    [StringLength(40)]
    public string? HcpTypDesc { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("service_ind")]
    [StringLength(1)]
    public string? ServiceInd { get; set; }

    [InverseProperty("HcpTypNavigation")]
    public virtual ICollection<HcpName> HcpName { get; set; } = new List<HcpName>();
}
