using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "TblName", "ColName")]
[Table("trf_col_to_ovride")]
public partial class TrfColToOvride
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Key]
    [Column("tbl_name")]
    [StringLength(30)]
    public string TblName { get; set; } = null!;

    [Key]
    [Column("col_name")]
    [StringLength(40)]
    public string ColName { get; set; } = null!;

    [Column("ovride_typ")]
    [StringLength(10)]
    public string OvrideTyp { get; set; } = null!;

    [Column("repl_val")]
    public string? ReplVal { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [ForeignKey("TblName, ColName")]
    [InverseProperty("TrfColToOvride")]
    public virtual ImpexpColumns ImpexpColumns { get; set; } = null!;

    [ForeignKey("InstId, TrfDirctn")]
    [InverseProperty("TrfColToOvride")]
    public virtual TrfInst TrfInst { get; set; } = null!;
}
