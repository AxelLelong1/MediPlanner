using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeId", "CmteeMbrStkhId")]
[Table("cmtee_mbr")]
public partial class CmteeMbr
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Key]
    [Column("cmtee_mbr_stkh_id")]
    [StringLength(20)]
    public string CmteeMbrStkhId { get; set; } = null!;

    [Column("cmtee_mbr_role_typ")]
    public int CmteeMbrRoleTyp { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("cmtee_chair_ind")]
    [StringLength(1)]
    public string? CmteeChairInd { get; set; }

    [Column("cmtee_vice_chair_ind")]
    [StringLength(1)]
    public string? CmteeViceChairInd { get; set; }

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

    [Column("sitting_mbr_ind")]
    [StringLength(1)]
    public string? SittingMbrInd { get; set; }
}
