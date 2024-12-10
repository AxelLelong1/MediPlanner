using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("QmValueSetId", "QmEventCodeId")]
[Table("xref_qm_value_set_event_code")]
public partial class XrefQmValueSetEventCode
{
    [Key]
    [Column("qm_value_set_id")]
    public int QmValueSetId { get; set; }

    [Key]
    [Column("qm_event_code_id")]
    public int QmEventCodeId { get; set; }

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

    [ForeignKey("QmEventCodeId")]
    [InverseProperty("XrefQmValueSetEventCode")]
    public virtual QmEventCode QmEventCode { get; set; } = null!;

    [ForeignKey("QmValueSetId")]
    [InverseProperty("XrefQmValueSetEventCode")]
    public virtual QmValueSet QmValueSet { get; set; } = null!;
}
