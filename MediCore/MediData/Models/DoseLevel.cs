using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dose_level")]
public partial class DoseLevel
{
    [Key]
    [Column("dose_level")]
    public int DoseLevel1 { get; set; }

    [Column("dose_level_desc")]
    [StringLength(40)]
    public string DoseLevelDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("DoseLevelNavigation")]
    public virtual ICollection<AgtDosage> AgtDosage { get; set; } = new List<AgtDosage>();
}
