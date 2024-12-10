using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TestId", "TestSpcmnId")]
[Table("test_spcmn")]
public partial class TestSpcmn
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("test_id")]
    public int TestId { get; set; }

    [Key]
    [Column("test_spcmn_id")]
    public int TestSpcmnId { get; set; }

    [Column("obs_start_datetime", TypeName = "datetime")]
    public DateTime? ObsStartDatetime { get; set; }

    [Column("obs_end_datetime", TypeName = "datetime")]
    public DateTime? ObsEndDatetime { get; set; }

    [Column("collc_vol_id")]
    public int? CollcVolId { get; set; }

    [Column("collc_id")]
    [StringLength(20)]
    public string? CollcId { get; set; }

    [Column("spcmn_action_id")]
    public int? SpcmnActionId { get; set; }

    [Column("danger_cd")]
    [StringLength(20)]
    public string? DangerCd { get; set; }

    [Column("spcmn_source_id")]
    public int? SpcmnSourceId { get; set; }

    [Column("rlvnt_clinic_info")]
    public string? RlvntClinicInfo { get; set; }

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

    [Column("collc_vol_amt", TypeName = "numeric(11, 4)")]
    public decimal? CollcVolAmt { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("spcmn_reject_reason_id")]
    public int? SpcmnRejectReasonId { get; set; }

    [Column("spcmn_cond_id")]
    public int? SpcmnCondId { get; set; }

    [Column("spcmn_typ_id")]
    public int? SpcmnTypId { get; set; }

    [ForeignKey("CollcVolId")]
    [InverseProperty("TestSpcmn")]
    public virtual CollcVol? CollcVol { get; set; }

    [ForeignKey("SpcmnActionId")]
    [InverseProperty("TestSpcmn")]
    public virtual SpcmnAction? SpcmnAction { get; set; }

    [ForeignKey("SpcmnCondId")]
    [InverseProperty("TestSpcmn")]
    public virtual SpcmnCond? SpcmnCond { get; set; }

    [ForeignKey("SpcmnRejectReasonId")]
    [InverseProperty("TestSpcmn")]
    public virtual SpcmnRejectReason? SpcmnRejectReason { get; set; }

    [ForeignKey("SpcmnSourceId")]
    [InverseProperty("TestSpcmn")]
    public virtual SpcmnSource? SpcmnSource { get; set; }

    [ForeignKey("SpcmnTypId")]
    [InverseProperty("TestSpcmn")]
    public virtual SpcmnTyp? SpcmnTyp { get; set; }
}
