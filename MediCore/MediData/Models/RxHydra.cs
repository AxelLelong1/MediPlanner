using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "RxHydraId")]
[Table("rx_hydra")]
public partial class RxHydra
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("rx_id")]
    public int RxId { get; set; }

    [Key]
    [Column("rx_hydra_id")]
    public int RxHydraId { get; set; }

    [Column("hydra_fluid_id")]
    public int HydraFluidId { get; set; }

    [Column("hydra_vol", TypeName = "numeric(11, 4)")]
    public decimal? HydraVol { get; set; }

    [Column("hydra_vol_uom")]
    public int? HydraVolUom { get; set; }

    [Column("hydra_desc")]
    [StringLength(255)]
    public string? HydraDesc { get; set; }

    [Column("hydra_seq")]
    public int? HydraSeq { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("infusion_line")]
    public int? InfusionLine { get; set; }

    [Column("order_vol", TypeName = "numeric(11, 4)")]
    public decimal? OrderVol { get; set; }

    [Column("order_vol_uom")]
    public int? OrderVolUom { get; set; }

    [Column("total_bag_vol", TypeName = "numeric(11, 4)")]
    public decimal? TotalBagVol { get; set; }

    [Column("bag_calc_typ")]
    [StringLength(1)]
    public string? BagCalcTyp { get; set; }

    [ForeignKey("HydraFluidId")]
    [InverseProperty("RxHydra")]
    public virtual HydraFluid HydraFluid { get; set; } = null!;
}
