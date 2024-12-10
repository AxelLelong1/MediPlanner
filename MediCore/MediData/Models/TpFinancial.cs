using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "TpFinancialId")]
[Table("tp_financial")]
public partial class TpFinancial
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("tp_financial_id")]
    public int TpFinancialId { get; set; }

    [Column("award_typ")]
    public int? AwardTyp { get; set; }

    [Column("grant_typ_cd")]
    [StringLength(1)]
    public string? GrantTypCd { get; set; }

    [Column("grant_awarded_cd")]
    [StringLength(1)]
    public string? GrantAwardedCd { get; set; }

    [Column("ct_bill_complete_ind")]
    [StringLength(1)]
    public string? CtBillCompleteInd { get; set; }

    [Column("grant_pm_stkh_id")]
    [StringLength(20)]
    public string? GrantPmStkhId { get; set; }

    [Column("underwritten_date", TypeName = "datetime")]
    public DateTime? UnderwrittenDate { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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
