using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("unit_of_meas")]
[Index("MediUom", Name = "nc1_unit_of_meas")]
public partial class UnitOfMeas
{
    [Key]
    [Column("uom")]
    public int Uom { get; set; }

    [Column("uom_desc")]
    [StringLength(40)]
    public string UomDesc { get; set; } = null!;

    [Column("medi_uom")]
    [StringLength(10)]
    public string? MediUom { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("base_unit")]
    public int? BaseUnit { get; set; }

    [Column("ordering_uom")]
    public int? OrderingUom { get; set; }

    [Column("per_vol_amt", TypeName = "numeric(11, 4)")]
    public decimal? PerVolAmt { get; set; }

    [Column("per_vol_uom")]
    public int? PerVolUom { get; set; }

    [Column("uom_abbr")]
    [StringLength(10)]
    public string? UomAbbr { get; set; }

    [InverseProperty("UomNavigation")]
    public virtual ICollection<AgtDosage> AgtDosage { get; set; } = new List<AgtDosage>();

    [InverseProperty("UomNavigation")]
    public virtual ICollection<FacUomMap> FacUomMap { get; set; } = new List<FacUomMap>();

    [InverseProperty("SyringeVolUomNavigation")]
    public virtual ICollection<MaxSyringeVol> MaxSyringeVol { get; set; } = new List<MaxSyringeVol>();

    [InverseProperty("DoseUomNavigation")]
    public virtual ICollection<OncoPtFsDrugDet> OncoPtFsDrugDetDoseUomNavigation { get; set; } = new List<OncoPtFsDrugDet>();

    [InverseProperty("FluidUomNavigation")]
    public virtual ICollection<OncoPtFsDrugDet> OncoPtFsDrugDetFluidUomNavigation { get; set; } = new List<OncoPtFsDrugDet>();

    [InverseProperty("AgtDoseUnitNavigation")]
    public virtual ICollection<PtIvTherapy> PtIvTherapyAgtDoseUnitNavigation { get; set; } = new List<PtIvTherapy>();

    [InverseProperty("IvRateUnitNavigation")]
    public virtual ICollection<PtIvTherapy> PtIvTherapyIvRateUnitNavigation { get; set; } = new List<PtIvTherapy>();

    [InverseProperty("AdmnDosageUnitNavigation")]
    public virtual ICollection<PtTpAgt> PtTpAgt { get; set; } = new List<PtTpAgt>();

    [InverseProperty("AgtDoseUnitNavigation")]
    public virtual ICollection<PtTpIvTherapy> PtTpIvTherapyAgtDoseUnitNavigation { get; set; } = new List<PtTpIvTherapy>();

    [InverseProperty("IvRateUnitNavigation")]
    public virtual ICollection<PtTpIvTherapy> PtTpIvTherapyIvRateUnitNavigation { get; set; } = new List<PtTpIvTherapy>();

    [InverseProperty("AdmnDosageUnitNavigation")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();

    [InverseProperty("AgtDoseUnitNavigation")]
    public virtual ICollection<TpIvTherapy> TpIvTherapyAgtDoseUnitNavigation { get; set; } = new List<TpIvTherapy>();

    [InverseProperty("IvRateUnitNavigation")]
    public virtual ICollection<TpIvTherapy> TpIvTherapyIvRateUnitNavigation { get; set; } = new List<TpIvTherapy>();

    [InverseProperty("TrUnitsNavigation")]
    public virtual ICollection<TrComp> TrComp { get; set; } = new List<TrComp>();

    [InverseProperty("UomNavigation")]
    public virtual ICollection<XrefUcumUnit> XrefUcumUnit { get; set; } = new List<XrefUcumUnit>();

    [InverseProperty("UomNavigation")]
    public virtual ICollection<XrefUnitFcn> XrefUnitFcn { get; set; } = new List<XrefUnitFcn>();
}
