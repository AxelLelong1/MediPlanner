using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeId", "CmteeDateId", "CmteeCcId")]
[Table("cmtee_rcmd_cc")]
public partial class CmteeRcmdCc
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Key]
    [Column("cmtee_date_id")]
    public int CmteeDateId { get; set; }

    [Key]
    [Column("cmtee_cc_id")]
    public int CmteeCcId { get; set; }

    [Column("cmtee_mbr_stkh_id")]
    [StringLength(20)]
    public string CmteeMbrStkhId { get; set; } = null!;

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
