using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("value_typ")]
public partial class ValueTyp
{
    [Key]
    [Column("value_typ")]
    public int ValueTyp1 { get; set; }

    [Column("value_desc")]
    [StringLength(20)]
    public string? ValueDesc { get; set; }

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

    [Column("value_use_desc")]
    [StringLength(30)]
    public string? ValueUseDesc { get; set; }

    [Column("value_update_ind")]
    [StringLength(1)]
    public string? ValueUpdateInd { get; set; }

    [Column("value_use_ind")]
    [StringLength(1)]
    public string? ValueUseInd { get; set; }

    [InverseProperty("ValueUpdateTypNavigation")]
    public virtual ICollection<InstDoseMgmt> InstDoseMgmt { get; set; } = new List<InstDoseMgmt>();

    [InverseProperty("AltValueTypNavigation")]
    public virtual ICollection<PtDoseData> PtDoseDataAltValueTypNavigation { get; set; } = new List<PtDoseData>();

    [InverseProperty("CompValueTypNavigation")]
    public virtual ICollection<PtDoseData> PtDoseDataCompValueTypNavigation { get; set; } = new List<PtDoseData>();

    [InverseProperty("ValueUpdateTypNavigation")]
    public virtual ICollection<TpDoseMgmt> TpDoseMgmt { get; set; } = new List<TpDoseMgmt>();
}
