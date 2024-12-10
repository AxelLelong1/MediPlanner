using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_name")]
public partial class AgtName
{
    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName1 { get; set; } = null!;

    [Column("agt_typ")]
    public int AgtTyp { get; set; }

    [Column("per_meter_sq")]
    [StringLength(1)]
    public string? PerMeterSq { get; set; }

    [Column("medi_drug_name")]
    [StringLength(30)]
    public string? MediDrugName { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

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

    [Column("agt_category")]
    [StringLength(14)]
    public string? AgtCategory { get; set; }

    [InverseProperty("AgtNameNavigation")]
    public virtual ICollection<AgtContraInd> AgtContraInd { get; set; } = new List<AgtContraInd>();

    [InverseProperty("AgtNameNavigation")]
    public virtual ICollection<AgtDosage> AgtDosage { get; set; } = new List<AgtDosage>();

    [InverseProperty("AgtNameNavigation")]
    public virtual ICollection<AgtNote> AgtNote { get; set; } = new List<AgtNote>();

    [InverseProperty("AgtNameNavigation")]
    public virtual ICollection<AgtTr> AgtTr { get; set; } = new List<AgtTr>();

    [ForeignKey("AgtTyp")]
    [InverseProperty("AgtName")]
    public virtual AgtTyp AgtTypNavigation { get; set; } = null!;

    [InverseProperty("AgtNameNavigation")]
    public virtual ICollection<OtherName> OtherName { get; set; } = new List<OtherName>();
}
