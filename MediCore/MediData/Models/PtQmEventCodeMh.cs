using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtQmEventCodeId", "RevisionNo")]
[Table("pt_qm_event_code_mh")]
public partial class PtQmEventCodeMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_qm_event_code_id")]
    public int PtQmEventCodeId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("qm_event_code_id")]
    public int QmEventCodeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("err_rsn")]
    [StringLength(255)]
    public string? ErrRsn { get; set; }

    [Column("not_done_qm_value_set_id")]
    public int? NotDoneQmValueSetId { get; set; }

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
}
