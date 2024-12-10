﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "IntvId")]
[Table("pt_tp_agt")]
public partial class PtTpAgt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dose_level")]
    public int DoseLevel { get; set; }

    [Column("dosage_form")]
    public int DosageForm { get; set; }

    [Column("subs")]
    [StringLength(1)]
    public string Subs { get; set; } = null!;

    [Column("brand")]
    [StringLength(50)]
    public string? Brand { get; set; }

    [Column("admn_dosage", TypeName = "decimal(11, 4)")]
    public decimal? AdmnDosage { get; set; }

    [Column("admn_dosage_unit")]
    public int AdmnDosageUnit { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("infusion_typ")]
    public int? InfusionTyp { get; set; }

    [Column("infusion_duration")]
    public int? InfusionDuration { get; set; }

    [Column("infusion_timescale")]
    public int? InfusionTimescale { get; set; }

    [Column("special_instr")]
    public string? SpecialInstr { get; set; }

    [Column("round_mthd")]
    public int? RoundMthd { get; set; }

    [Column("round_factor", TypeName = "decimal(11, 4)")]
    public decimal? RoundFactor { get; set; }

    [Column("max_bsa_dose", TypeName = "decimal(11, 4)")]
    public decimal? MaxBsaDose { get; set; }

    [Column("abs_max_dose", TypeName = "decimal(11, 4)")]
    public decimal? AbsMaxDose { get; set; }

    [Column("ideal_wt")]
    [StringLength(1)]
    public string? IdealWt { get; set; }

    [Column("above_actual_wt", TypeName = "decimal(11, 4)")]
    public decimal? AboveActualWt { get; set; }

    [Column("cost_per_course", TypeName = "decimal(11, 4)")]
    public decimal? CostPerCourse { get; set; }

    [Column("currency")]
    public int? Currency { get; set; }

    [Column("rx_typ")]
    public int? RxTyp { get; set; }

    [Column("mod")]
    [StringLength(1)]
    public string? Mod { get; set; }

    [Column("vrtn_amount", TypeName = "decimal(11, 4)")]
    public decimal? VrtnAmount { get; set; }

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string? DrugDescId { get; set; }

    [Column("admn_dosage_range", TypeName = "decimal(11, 4)")]
    public decimal? AdmnDosageRange { get; set; }

    [Column("strength", TypeName = "decimal(11, 4)")]
    public decimal? Strength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

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

    [Column("medi_active_ind")]
    [StringLength(1)]
    public string? MediActiveInd { get; set; }

    [Column("active_chg_date", TypeName = "datetime")]
    public DateTime? ActiveChgDate { get; set; }

    [Column("agt_seq_no")]
    public int? AgtSeqNo { get; set; }

    [Column("refill_ind")]
    [StringLength(1)]
    public string? RefillInd { get; set; }

    [Column("refill_qty")]
    public int? RefillQty { get; set; }

    [Column("dose_strength")]
    [StringLength(15)]
    public string? DoseStrength { get; set; }

    [Column("hydra_fluid_id")]
    public int? HydraFluidId { get; set; }

    [Column("hydra_vol", TypeName = "numeric(11, 4)")]
    public decimal? HydraVol { get; set; }

    [Column("hydra_vol_uom")]
    public int? HydraVolUom { get; set; }

    [Column("hydra_seq")]
    public int? HydraSeq { get; set; }

    [Column("tx_tframe_typ")]
    public int? TxTframeTyp { get; set; }

    [Column("intv_use_typ")]
    public int? IntvUseTyp { get; set; }

    [Column("take_as_directed_ind")]
    [StringLength(1)]
    public string? TakeAsDirectedInd { get; set; }

    [Column("infusion_line")]
    public int? InfusionLine { get; set; }

    [ForeignKey("AdmnDosageUnit")]
    [InverseProperty("PtTpAgt")]
    public virtual UnitOfMeas AdmnDosageUnitNavigation { get; set; } = null!;

    [ForeignKey("AdmnRoute")]
    [InverseProperty("PtTpAgt")]
    public virtual AdmnRoute? AdmnRouteNavigation { get; set; }

    [ForeignKey("HydraFluidId")]
    [InverseProperty("PtTpAgt")]
    public virtual HydraFluid? HydraFluid { get; set; }

    [ForeignKey("InfusionTyp")]
    [InverseProperty("PtTpAgt")]
    public virtual InfusionTyp? InfusionTypNavigation { get; set; }

    [InverseProperty("PtTpAgt")]
    public virtual ICollection<PtTpAgtCourse> PtTpAgtCourse { get; set; } = new List<PtTpAgtCourse>();

    [ForeignKey("PtId, DateTpInit, IntvId")]
    [InverseProperty("PtTpAgt")]
    public virtual PtTpIntv PtTpIntv { get; set; } = null!;

    [ForeignKey("RxTyp")]
    [InverseProperty("PtTpAgt")]
    public virtual RxTyp? RxTypNavigation { get; set; }
}