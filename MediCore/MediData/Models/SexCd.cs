using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("sex_cd")]
public partial class SexCd
{
    [Key]
    [Column("sex_cd")]
    [StringLength(1)]
    public string SexCd1 { get; set; } = null!;

    [Column("sex_desc")]
    [StringLength(40)]
    public string SexDesc { get; set; } = null!;

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

    [InverseProperty("SexCdNavigation")]
    public virtual ICollection<Pt> Pt { get; set; } = new List<Pt>();
}
