using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeAgendaId", "MbrStkhId")]
[Table("cmtee_agenda_mins_mbr")]
public partial class CmteeAgendaMinsMbr
{
    [Key]
    [Column("cmtee_agenda_id")]
    public int CmteeAgendaId { get; set; }

    [Key]
    [Column("mbr_stkh_id")]
    [StringLength(20)]
    public string MbrStkhId { get; set; } = null!;

    [Column("mbr_attend_ind")]
    [StringLength(1)]
    public string? MbrAttendInd { get; set; }

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
