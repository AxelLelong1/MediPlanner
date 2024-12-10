using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hydra_fluid")]
public partial class HydraFluid
{
    [Key]
    [Column("hydra_fluid_id")]
    public int HydraFluidId { get; set; }

    [Column("hydra_fluid_desc")]
    [StringLength(255)]
    public string? HydraFluidDesc { get; set; }

    [Column("hydra_fluid_display")]
    [StringLength(255)]
    public string? HydraFluidDisplay { get; set; }

    [Column("hydra_fluid_abbr")]
    [StringLength(10)]
    public string? HydraFluidAbbr { get; set; }

    [Column("display_seq")]
    public int? DisplaySeq { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

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

    [InverseProperty("HydraFluid")]
    public virtual ICollection<PtTpAgt> PtTpAgt { get; set; } = new List<PtTpAgt>();

    [InverseProperty("HydraFluid")]
    public virtual ICollection<RxHydra> RxHydra { get; set; } = new List<RxHydra>();

    [InverseProperty("HydraFluid")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();
}
