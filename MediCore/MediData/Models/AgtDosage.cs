using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AgtName", "DosageForm", "DoseLevel")]
[Table("agt_dosage")]
public partial class AgtDosage
{
    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Key]
    [Column("dosage_form")]
    public int DosageForm { get; set; }

    [Key]
    [Column("dose_level")]
    public int DoseLevel { get; set; }

    [Column("lower_dose", TypeName = "decimal(11, 4)")]
    public decimal? LowerDose { get; set; }

    [Column("upper_dose", TypeName = "decimal(11, 4)")]
    public decimal? UpperDose { get; set; }

    [Column("dose_round_mthd")]
    public int? DoseRoundMthd { get; set; }

    [Column("qty_single_dose")]
    public int? QtySingleDose { get; set; }

    [Column("direct_drug_cost", TypeName = "decimal(8, 2)")]
    public decimal? DirectDrugCost { get; set; }

    [Column("bsa_dose_flag")]
    [StringLength(1)]
    public string? BsaDoseFlag { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("reconstitution")]
    public string? Reconstitution { get; set; }

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

    [Column("take_as_directed_ind")]
    [StringLength(1)]
    public string? TakeAsDirectedInd { get; set; }

    [ForeignKey("AgtName")]
    [InverseProperty("AgtDosage")]
    public virtual AgtName AgtNameNavigation { get; set; } = null!;

    [ForeignKey("DosageForm")]
    [InverseProperty("AgtDosage")]
    public virtual DosageForm DosageFormNavigation { get; set; } = null!;

    [ForeignKey("DoseLevel")]
    [InverseProperty("AgtDosage")]
    public virtual DoseLevel DoseLevelNavigation { get; set; } = null!;

    [ForeignKey("DoseRoundMthd")]
    [InverseProperty("AgtDosage")]
    public virtual DoseRoundMthd? DoseRoundMthdNavigation { get; set; }

    [InverseProperty("AgtDosage")]
    public virtual ICollection<InfusionDetails> InfusionDetails { get; set; } = new List<InfusionDetails>();

    [InverseProperty("AgtDosage")]
    public virtual ICollection<Instr> Instr { get; set; } = new List<Instr>();

    [ForeignKey("Uom")]
    [InverseProperty("AgtDosage")]
    public virtual UnitOfMeas? UomNavigation { get; set; }
}
