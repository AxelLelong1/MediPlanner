using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "RefId", "CdVal")]
[Table("cd_tbl_val")]
[Index("RefId", Name = "nc1_cd_tbl_val")]
public partial class CdTblVal
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("ref_id")]
    [StringLength(15)]
    public string RefId { get; set; } = null!;

    [Key]
    [Column("cd_val")]
    [StringLength(60)]
    public string CdVal { get; set; } = null!;

    [Column("cd_val_desc")]
    [StringLength(255)]
    public string? CdValDesc { get; set; }

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

    [ForeignKey("InstId, RefId")]
    [InverseProperty("CdTblVal")]
    public virtual RefDef RefDef { get; set; } = null!;
}
