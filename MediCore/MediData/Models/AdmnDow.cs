using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DowFrqUnit", "AdmnDow1")]
[Table("admn_dow")]
public partial class AdmnDow
{
    [Key]
    [Column("dow_frq_unit")]
    public int DowFrqUnit { get; set; }

    [Key]
    [Column("admn_dow")]
    public int AdmnDow1 { get; set; }

    [Column("interval_secs")]
    public int IntervalSecs { get; set; }

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

    [ForeignKey("DowFrqUnit")]
    [InverseProperty("AdmnDow")]
    public virtual DowFrqUnit DowFrqUnitNavigation { get; set; } = null!;
}
