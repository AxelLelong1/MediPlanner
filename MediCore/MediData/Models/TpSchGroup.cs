using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "GroupIntvId", "CompIntvId")]
[Table("tp_sch_group")]
public partial class TpSchGroup
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("group_intv_id")]
    public int GroupIntvId { get; set; }

    [Key]
    [Column("comp_intv_id")]
    public int CompIntvId { get; set; }

    [Column("comp_seq_no")]
    public int? CompSeqNo { get; set; }

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

    [ForeignKey("TpName, TpVersNo, CompIntvId")]
    [InverseProperty("TpSchGroupTpIntv")]
    public virtual TpIntv TpIntv { get; set; } = null!;

    [ForeignKey("TpName, TpVersNo, GroupIntvId")]
    [InverseProperty("TpSchGroupTpIntvNavigation")]
    public virtual TpIntv TpIntvNavigation { get; set; } = null!;
}
