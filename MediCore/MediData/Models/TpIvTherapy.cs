using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "IntvId")]
[Table("tp_iv_therapy")]
public partial class TpIvTherapy
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("iv_fluid_name")]
    [StringLength(60)]
    public string IvFluidName { get; set; } = null!;

    [Column("iv_fluid_cd")]
    [StringLength(10)]
    public string? IvFluidCd { get; set; }

    [Column("gnrc_iv_fluid_name")]
    [StringLength(60)]
    public string? GnrcIvFluidName { get; set; }

    [Column("iv_rate")]
    public int IvRate { get; set; }

    [Column("iv_rate_unit")]
    public int? IvRateUnit { get; set; }

    [Column("infusion_typ")]
    public int? InfusionTyp { get; set; }

    [Column("special_instr")]
    public string? SpecialInstr { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string? AgtName { get; set; }

    [Column("agt_dose", TypeName = "decimal(11, 4)")]
    public decimal? AgtDose { get; set; }

    [Column("agt_dose_range", TypeName = "decimal(11, 4)")]
    public decimal? AgtDoseRange { get; set; }

    [Column("agt_dose_unit")]
    public int? AgtDoseUnit { get; set; }

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

    [ForeignKey("AgtDoseUnit")]
    [InverseProperty("TpIvTherapyAgtDoseUnitNavigation")]
    public virtual UnitOfMeas? AgtDoseUnitNavigation { get; set; }

    [ForeignKey("GnrcIvFluidName")]
    [InverseProperty("TpIvTherapy")]
    public virtual IvFluid? GnrcIvFluidNameNavigation { get; set; }

    [ForeignKey("InfusionTyp")]
    [InverseProperty("TpIvTherapy")]
    public virtual InfusionTyp? InfusionTypNavigation { get; set; }

    [ForeignKey("IvRateUnit")]
    [InverseProperty("TpIvTherapyIvRateUnitNavigation")]
    public virtual UnitOfMeas? IvRateUnitNavigation { get; set; }

    [ForeignKey("TpName, TpVersNo, IntvId")]
    [InverseProperty("TpIvTherapy")]
    public virtual TpIntv TpIntv { get; set; } = null!;
}
