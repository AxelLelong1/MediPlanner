using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "TpAccrualId")]
[Table("tp_ct_exptd_dur_accrual")]
public partial class TpCtExptdDurAccrual
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
    [Column("tp_accrual_id")]
    public int TpAccrualId { get; set; }

    [Column("exptd_dur_trial_amt")]
    public int? ExptdDurTrialAmt { get; set; }

    [Column("exptd_dur_pt_amt")]
    public int? ExptdDurPtAmt { get; set; }

    [Column("exptd_dur_accrual_amt")]
    public int? ExptdDurAccrualAmt { get; set; }

    [Column("exptd_dur_trial_uom")]
    public int? ExptdDurTrialUom { get; set; }

    [Column("exptd_dur_pt_uom")]
    public int? ExptdDurPtUom { get; set; }

    [Column("exptd_dur_accrual_uom")]
    public int? ExptdDurAccrualUom { get; set; }

    [Column("exptd_accrual_pt_amt")]
    public int? ExptdAccrualPtAmt { get; set; }

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
