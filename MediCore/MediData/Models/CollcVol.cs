using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("collc_vol")]
public partial class CollcVol
{
    [Key]
    [Column("collc_vol_id")]
    public int CollcVolId { get; set; }

    [Column("collc_vol_desc")]
    [StringLength(30)]
    public string CollcVolDesc { get; set; } = null!;

    [Column("collc_vol_cd")]
    [StringLength(5)]
    public string? CollcVolCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("CollcVol")]
    public virtual ICollection<TestSpcmn> TestSpcmn { get; set; } = new List<TestSpcmn>();
}
