using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "CareUnitId")]
[Table("inst_care_unit")]
public partial class InstCareUnit
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("care_unit_id")]
    public int CareUnitId { get; set; }

    [Column("care_unit")]
    [StringLength(10)]
    public string CareUnit { get; set; } = null!;

    [Column("care_unit_desc")]
    [StringLength(100)]
    public string CareUnitDesc { get; set; } = null!;

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

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("printer")]
    [StringLength(255)]
    public string? Printer { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("InstCareUnit")]
    public virtual Inst Inst { get; set; } = null!;

    [InverseProperty("InstCareUnit")]
    public virtual ICollection<InstCareBed> InstCareBed { get; set; } = new List<InstCareBed>();
}
