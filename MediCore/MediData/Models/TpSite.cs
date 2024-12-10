using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpSiteId", "TpName", "TpVersNo", "SiteStkhId")]
[Table("tp_site")]
public partial class TpSite
{
    [Key]
    [Column("tp_site_id")]
    public int TpSiteId { get; set; }

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("site_stkh_id")]
    [StringLength(20)]
    public string SiteStkhId { get; set; } = null!;

    [Column("ct_open_date", TypeName = "datetime")]
    public DateTime? CtOpenDate { get; set; }

    [Column("ct_close_date", TypeName = "datetime")]
    public DateTime? CtCloseDate { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("site_status_typ")]
    public int? SiteStatusTyp { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("status_set_cd")]
    [StringLength(1)]
    public string? StatusSetCd { get; set; }

    [Column("ltr_id")]
    public int? LtrId { get; set; }

    [Column("final_ltr_id")]
    public int? FinalLtrId { get; set; }

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
