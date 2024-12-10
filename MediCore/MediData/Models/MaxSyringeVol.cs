using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AdmnRoute")]
[Table("max_syringe_vol")]
public partial class MaxSyringeVol
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("admn_route")]
    public int AdmnRoute { get; set; }

    [Column("syringe_vol", TypeName = "numeric(11, 4)")]
    public decimal? SyringeVol { get; set; }

    [Column("syringe_vol_uom")]
    public int? SyringeVolUom { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("AdmnRoute")]
    [InverseProperty("MaxSyringeVol")]
    public virtual AdmnRoute AdmnRouteNavigation { get; set; } = null!;

    [ForeignKey("SyringeVolUom")]
    [InverseProperty("MaxSyringeVol")]
    public virtual UnitOfMeas? SyringeVolUomNavigation { get; set; }
}
