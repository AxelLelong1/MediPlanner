using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dosage_form")]
public partial class DosageForm
{
    [Key]
    [Column("dosage_form")]
    public int DosageForm1 { get; set; }

    [Column("dosage_form_desc")]
    [StringLength(40)]
    public string DosageFormDesc { get; set; } = null!;

    [Column("medi_dose_form")]
    [StringLength(4)]
    public string? MediDoseForm { get; set; }

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

    [Column("form_typ")]
    public int? FormTyp { get; set; }

    [Column("iBaseFormulationID")]
    public int? IBaseFormulationId { get; set; }

    [Column("FDA_dosage_form")]
    public int? FdaDosageForm { get; set; }

    [InverseProperty("DosageFormNavigation")]
    public virtual ICollection<AgtDosage> AgtDosage { get; set; } = new List<AgtDosage>();

    [InverseProperty("DosageFormNavigation")]
    public virtual ICollection<DosageFormExtDrugDb> DosageFormExtDrugDb { get; set; } = new List<DosageFormExtDrugDb>();
}
