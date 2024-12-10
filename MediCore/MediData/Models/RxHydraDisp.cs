using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "RxHydraDispId")]
[Table("rx_hydra_disp")]
public partial class RxHydraDisp
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
    [Column("rx_hydra_disp_id")]
    public int RxHydraDispId { get; set; }

    [Column("disp_tstamp", TypeName = "datetime")]
    public DateTime? DispTstamp { get; set; }

    [Column("disp_hydra_desc")]
    [StringLength(255)]
    public string? DispHydraDesc { get; set; }

    [Column("disp_hydra_seq")]
    public int? DispHydraSeq { get; set; }

    [Column("disp_appr_ind")]
    [StringLength(1)]
    public string? DispApprInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("disp_hydra_fluid_id")]
    public int? DispHydraFluidId { get; set; }

    [Column("disp_hydra_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispHydraVol { get; set; }

    [Column("disp_hydra_vol_uom")]
    public int? DispHydraVolUom { get; set; }

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }
}
