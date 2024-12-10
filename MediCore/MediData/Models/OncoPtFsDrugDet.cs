using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "OncoPtFsDetId", "OncoPtFsDrugId", "OncoPtFsDrugDetId")]
[Table("onco_pt_fs_drug_det")]
public partial class OncoPtFsDrugDet
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("onco_pt_fs_det_id")]
    [StringLength(25)]
    public string OncoPtFsDetId { get; set; } = null!;

    [Key]
    [Column("onco_pt_fs_drug_id")]
    [StringLength(25)]
    public string OncoPtFsDrugId { get; set; } = null!;

    [Key]
    [Column("onco_pt_fs_drug_det_id")]
    [StringLength(25)]
    public string OncoPtFsDrugDetId { get; set; } = null!;

    [Column("dose_value", TypeName = "decimal(4, 0)")]
    public decimal? DoseValue { get; set; }

    [Column("dose_uom")]
    public int? DoseUom { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("fluid_desc")]
    [StringLength(20)]
    public string? FluidDesc { get; set; }

    [Column("fluid_quantity", TypeName = "decimal(4, 0)")]
    public decimal? FluidQuantity { get; set; }

    [Column("fluid_uom")]
    public int? FluidUom { get; set; }

    [Column("scheduled_datetime", TypeName = "datetime")]
    public DateTime? ScheduledDatetime { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("instructions")]
    public string? Instructions { get; set; }

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

    [ForeignKey("DoseUom")]
    [InverseProperty("OncoPtFsDrugDetDoseUomNavigation")]
    public virtual UnitOfMeas? DoseUomNavigation { get; set; }

    [ForeignKey("FluidUom")]
    [InverseProperty("OncoPtFsDrugDetFluidUomNavigation")]
    public virtual UnitOfMeas? FluidUomNavigation { get; set; }

    [ForeignKey("PtId, OncoPtFsDetId, OncoPtFsDrugId")]
    [InverseProperty("OncoPtFsDrugDet")]
    public virtual OncoPtFsDrug OncoPtFsDrug { get; set; } = null!;
}
