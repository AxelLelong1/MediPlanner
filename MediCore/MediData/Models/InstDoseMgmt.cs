using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "CompName")]
[Table("inst_dose_mgmt")]
public partial class InstDoseMgmt
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("value_update_typ")]
    public int ValueUpdateTyp { get; set; }

    [Column("update_value", TypeName = "decimal(11, 4)")]
    public decimal? UpdateValue { get; set; }

    [Column("update_unit")]
    public int? UpdateUnit { get; set; }

    [Column("value_use_typ")]
    public int? ValueUseTyp { get; set; }

    [Column("use_value", TypeName = "decimal(11, 4)")]
    public decimal? UseValue { get; set; }

    [Column("use_unit")]
    public int? UseUnit { get; set; }

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
    [InverseProperty("InstDoseMgmt")]
    public virtual Inst Inst { get; set; } = null!;

    [ForeignKey("ValueUpdateTyp")]
    [InverseProperty("InstDoseMgmt")]
    public virtual ValueTyp ValueUpdateTypNavigation { get; set; } = null!;
}
