using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AgtName", "DosageForm", "DoseLevel", "InfusionTyp")]
[Table("infusion_details")]
public partial class InfusionDetails
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

    [Key]
    [Column("infusion_typ")]
    public int InfusionTyp { get; set; }

    [Column("infusion_details")]
    public string InfusionDetails1 { get; set; } = null!;

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

    [ForeignKey("AgtName, DosageForm, DoseLevel")]
    [InverseProperty("InfusionDetails")]
    public virtual AgtDosage AgtDosage { get; set; } = null!;

    [ForeignKey("InfusionTyp")]
    [InverseProperty("InfusionDetails")]
    public virtual InfusionTyp InfusionTypNavigation { get; set; } = null!;
}
