using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "ShiftId")]
[Table("inst_shift")]
public partial class InstShift
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("shift_id")]
    public int ShiftId { get; set; }

    [Column("shift_desc")]
    [StringLength(30)]
    public string ShiftDesc { get; set; } = null!;

    [Column("shift_cd")]
    [StringLength(2)]
    public string ShiftCd { get; set; } = null!;

    [Column("shift_start")]
    [StringLength(4)]
    public string ShiftStart { get; set; } = null!;

    [Column("shift_end")]
    [StringLength(4)]
    public string ShiftEnd { get; set; } = null!;

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

    [ForeignKey("InstId")]
    [InverseProperty("InstShift")]
    public virtual Inst Inst { get; set; } = null!;
}
