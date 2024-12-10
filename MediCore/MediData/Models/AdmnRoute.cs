using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("admn_route")]
public partial class AdmnRoute
{
    [Key]
    [Column("admn_route")]
    public int AdmnRoute1 { get; set; }

    [Column("admn_route_desc")]
    [StringLength(40)]
    public string AdmnRouteDesc { get; set; } = null!;

    [Column("medi_admn_route")]
    [StringLength(2)]
    public string? MediAdmnRoute { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("combo_route_ind")]
    [StringLength(1)]
    public string? ComboRouteInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("route_grp")]
    public int? RouteGrp { get; set; }

    [Column("dsp_desc")]
    [StringLength(40)]
    public string? DspDesc { get; set; }

    [Column("hl7_admn_route")]
    [StringLength(3)]
    public string? Hl7AdmnRoute { get; set; }

    [Column("base_admn_route")]
    public int? BaseAdmnRoute { get; set; }

    [Column("iRoutePrescribedID")]
    public int? IRoutePrescribedId { get; set; }

    [Column("infusible_ind")]
    [StringLength(1)]
    public string? InfusibleInd { get; set; }

    [Column("FDA_admn_route")]
    public int? FdaAdmnRoute { get; set; }

    [InverseProperty("AdmnRouteNavigation")]
    public virtual ICollection<AdmnRouteExtDrugDb> AdmnRouteExtDrugDb { get; set; } = new List<AdmnRouteExtDrugDb>();

    [InverseProperty("AdmnRoute")]
    public virtual ICollection<ImmunAdmnRoute> ImmunAdmnRoute { get; set; } = new List<ImmunAdmnRoute>();

    [InverseProperty("AdmnRouteNavigation")]
    public virtual ICollection<MaxSyringeVol> MaxSyringeVol { get; set; } = new List<MaxSyringeVol>();

    [InverseProperty("AdmnRouteNavigation")]
    public virtual ICollection<PtTpAgt> PtTpAgt { get; set; } = new List<PtTpAgt>();

    [InverseProperty("AdmnRouteNavigation")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();
}
