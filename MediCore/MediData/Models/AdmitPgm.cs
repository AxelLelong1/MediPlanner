using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PgmInstId", "PgmId")]
[Table("admit_pgm")]
public partial class AdmitPgm
{
    [Key]
    [Column("pgm_inst_id")]
    [StringLength(30)]
    public string PgmInstId { get; set; } = null!;

    [Key]
    [Column("pgm_id")]
    public int PgmId { get; set; }

    [Column("pgm_desc")]
    [StringLength(40)]
    public string PgmDesc { get; set; } = null!;

    [Column("pgm_cd")]
    [StringLength(5)]
    public string PgmCd { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [InverseProperty("AdmitPgm")]
    public virtual ICollection<PtAdt> PtAdt { get; set; } = new List<PtAdt>();
}
