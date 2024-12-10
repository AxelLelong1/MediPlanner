using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("QmValueSetId", "QmRsnNotDoneValueSetId")]
[Table("qm_rsn_not_done_value_set")]
public partial class QmRsnNotDoneValueSet
{
    [Key]
    [Column("qm_value_set_id")]
    public int QmValueSetId { get; set; }

    [Key]
    [Column("qm_rsn_not_done_value_set_id")]
    public int QmRsnNotDoneValueSetId { get; set; }

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

    [ForeignKey("QmRsnNotDoneValueSetId")]
    [InverseProperty("QmRsnNotDoneValueSetQmRsnNotDoneValueSetNavigation")]
    public virtual QmValueSet QmRsnNotDoneValueSetNavigation { get; set; } = null!;

    [ForeignKey("QmValueSetId")]
    [InverseProperty("QmRsnNotDoneValueSetQmValueSet")]
    public virtual QmValueSet QmValueSet { get; set; } = null!;
}
