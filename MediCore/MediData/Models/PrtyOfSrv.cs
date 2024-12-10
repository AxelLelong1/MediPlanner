using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("prty_of_srv")]
public partial class PrtyOfSrv
{
    [Key]
    [Column("prty_of_srv")]
    public int PrtyOfSrv1 { get; set; }

    [Column("prty_of_srv_desc")]
    [StringLength(40)]
    public string PrtyOfSrvDesc { get; set; } = null!;

    [Column("prty_of_srv_cd")]
    [StringLength(5)]
    public string? PrtyOfSrvCd { get; set; }

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

    [InverseProperty("PrtyOfSrvNavigation")]
    public virtual ICollection<Test> Test { get; set; } = new List<Test>();
}
