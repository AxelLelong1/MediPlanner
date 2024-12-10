using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_event_code_favorite")]
[Index("QmEventCodeId", Name = "nc1_qm_event_code_favorite")]
public partial class QmEventCodeFavorite
{
    [Key]
    [Column("qm_event_code_favorite_id")]
    public int QmEventCodeFavoriteId { get; set; }

    [Column("not_done_qm_value_set_id")]
    public int? NotDoneQmValueSetId { get; set; }

    [Column("qm_event_code_id")]
    public int QmEventCodeId { get; set; }

    [Column("qm_event_code_favorite_desc")]
    public string QmEventCodeFavoriteDesc { get; set; } = null!;

    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

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

    [ForeignKey("NotDoneQmValueSetId")]
    [InverseProperty("QmEventCodeFavorite")]
    public virtual QmValueSet? NotDoneQmValueSet { get; set; }

    [ForeignKey("QmEventCodeId")]
    [InverseProperty("QmEventCodeFavorite")]
    public virtual QmEventCode QmEventCode { get; set; } = null!;
}
