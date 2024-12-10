using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SchSeqNo", "RunTstamp")]
[Table("intf_sch")]
public partial class IntfSch
{
    [Key]
    [Column("sch_seq_no")]
    public int SchSeqNo { get; set; }

    [Key]
    [Column("run_tstamp", TypeName = "datetime")]
    public DateTime RunTstamp { get; set; }

    [Column("status_ind")]
    [StringLength(1)]
    public string? StatusInd { get; set; }

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

    [ForeignKey("SchSeqNo")]
    [InverseProperty("IntfSch")]
    public virtual IntfSchDef SchSeqNoNavigation { get; set; } = null!;
}
