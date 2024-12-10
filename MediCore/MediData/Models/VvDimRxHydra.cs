using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimRxHydra
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrrx_id")]
    public int CtrrxId { get; set; }

    [Column("ctrr_hydra_id")]
    public int CtrrHydraId { get; set; }

    public int RxHydraFluidId { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxHydraVolume { get; set; }

    public int? RxHydraVolumeUnit { get; set; }

    [StringLength(255)]
    public string? RxHydraDescription { get; set; }

    public int? RxHydraSequence { get; set; }

    public int? RxHydraInfusionLine { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxHydraOrderVolume { get; set; }

    public int? RxHydraOrderVolumeUnit { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxHydraTotalBagVolume { get; set; }

    [StringLength(1)]
    public string? RxHydraCalculationType { get; set; }
}
