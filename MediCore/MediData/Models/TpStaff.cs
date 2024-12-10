using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpStaffId", "TpName", "TpVersNo", "StaffStkhId")]
[Table("tp_staff")]
public partial class TpStaff
{
    [Key]
    [Column("tp_staff_id")]
    public int TpStaffId { get; set; }

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("staff_stkh_id")]
    [StringLength(20)]
    public string StaffStkhId { get; set; } = null!;

    [Column("site_stkh_id")]
    [StringLength(20)]
    public string SiteStkhId { get; set; } = null!;

    [Column("staff_start_date", TypeName = "datetime")]
    public DateTime? StaffStartDate { get; set; }

    [Column("staff_end_date", TypeName = "datetime")]
    public DateTime? StaffEndDate { get; set; }

    [Column("tp_role_typ")]
    public int? TpRoleTyp { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

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
