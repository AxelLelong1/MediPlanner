using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("QmId", "QmValueSetId")]
[Table("xref_qm_value_set_qm")]
public partial class XrefQmValueSetQm
{
    [Key]
    [Column("qm_id")]
    public int QmId { get; set; }

    [Key]
    [Column("qm_value_set_id")]
    public int QmValueSetId { get; set; }

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

    [ForeignKey("QmId")]
    [InverseProperty("XrefQmValueSetQm")]
    public virtual Qm Qm { get; set; } = null!;

    [ForeignKey("QmValueSetId")]
    [InverseProperty("XrefQmValueSetQm")]
    public virtual QmValueSet QmValueSet { get; set; } = null!;
}
