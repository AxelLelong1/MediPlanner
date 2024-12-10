﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "IntvId")]
[Table("pt_tp_iv_therapy")]
public partial class PtTpIvTherapy
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
    [InverseProperty("PtTpIvTherapyAgtDoseUnitNavigation")]
    public virtual UnitOfMeas? AgtDoseUnitNavigation { get; set; }

    [ForeignKey("InfusionTyp")]
    [InverseProperty("PtTpIvTherapy")]
    public virtual InfusionTyp? InfusionTypNavigation { get; set; }

    [ForeignKey("IvRateUnit")]
    [InverseProperty("PtTpIvTherapyIvRateUnitNavigation")]
    public virtual UnitOfMeas? IvRateUnitNavigation { get; set; }

    [ForeignKey("PtId, DateTpInit, IntvId")]
    [InverseProperty("PtTpIvTherapy")]
    public virtual PtTpIntv PtTpIntv { get; set; } = null!;
}