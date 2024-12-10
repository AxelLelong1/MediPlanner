using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "QstrName", "QstrId", "NonScheduledActivitySer", "ScheduledActivitySer")]
[Table("xref_pt_resp_hdr_appt_task")]
[Index("ScheduledActivitySer", Name = "nc1_xref_pt_resp_hdr_appt_task")]
[Index("NonScheduledActivitySer", Name = "nc2_xref_pt_resp_hdr_appt_task")]
public partial class XrefPtRespHdrApptTask
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("qstr_name")]
    [StringLength(20)]
    public string QstrName { get; set; } = null!;

    [Key]
    [Column("qstr_id")]
    public int QstrId { get; set; }

    [Key]
    public long NonScheduledActivitySer { get; set; }

    [Key]
    public long ScheduledActivitySer { get; set; }

    [Column("req_ind")]
    [StringLength(1)]
    public string ReqInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
