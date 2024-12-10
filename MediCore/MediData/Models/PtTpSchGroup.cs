using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "GroupIntvId", "CompIntvId")]
[Table("pt_tp_sch_group")]
public partial class PtTpSchGroup
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("group_intv_id")]
    public int GroupIntvId { get; set; }

    [Key]
    [Column("comp_intv_id")]
    public int CompIntvId { get; set; }

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

    [Column("comp_seq_no")]
    public int? CompSeqNo { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId, DateTpInit, CompIntvId")]
    [InverseProperty("PtTpSchGroupPtTpIntv")]
    public virtual PtTpIntv PtTpIntv { get; set; } = null!;

    [ForeignKey("PtId, DateTpInit, GroupIntvId")]
    [InverseProperty("PtTpSchGroupPtTpIntvNavigation")]
    public virtual PtTpIntv PtTpIntvNavigation { get; set; } = null!;
}
