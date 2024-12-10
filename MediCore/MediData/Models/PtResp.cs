using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "QstrName", "QstrId", "QuestionId")]
[Table("pt_resp")]
[Index("RespDatetime", Name = "nc1_pt_resp")]
[Index("QstrName", "QuestionId", Name = "nc2_pt_resp")]
public partial class PtResp
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
    [Column("question_id")]
    public int QuestionId { get; set; }

    [Column("resp")]
    [StringLength(255)]
    public string? Resp { get; set; }

    [Column("resp_txt")]
    public string? RespTxt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("resp_list_txt")]
    [StringLength(255)]
    public string? RespListTxt { get; set; }

    [Column("resp_pick_1_ind")]
    [StringLength(1)]
    public string? RespPick1Ind { get; set; }

    [Column("resp_pick_2_ind")]
    [StringLength(1)]
    public string? RespPick2Ind { get; set; }

    [Column("resp_pick_3_ind")]
    [StringLength(1)]
    public string? RespPick3Ind { get; set; }

    [Column("resp_pick_4_ind")]
    [StringLength(1)]
    public string? RespPick4Ind { get; set; }

    [Column("resp_pick_5_ind")]
    [StringLength(1)]
    public string? RespPick5Ind { get; set; }

    [Column("resp_pick_6_ind")]
    [StringLength(1)]
    public string? RespPick6Ind { get; set; }

    [Column("resp_pick_7_ind")]
    [StringLength(1)]
    public string? RespPick7Ind { get; set; }

    [Column("resp_pick_8_ind")]
    [StringLength(1)]
    public string? RespPick8Ind { get; set; }

    [Column("resp_pick_9_ind")]
    [StringLength(1)]
    public string? RespPick9Ind { get; set; }

    [Column("resp_pick_10_ind")]
    [StringLength(1)]
    public string? RespPick10Ind { get; set; }

    [Column("resp_pick_11_ind")]
    [StringLength(1)]
    public string? RespPick11Ind { get; set; }

    [Column("resp_pick_12_ind")]
    [StringLength(1)]
    public string? RespPick12Ind { get; set; }

    [Column("resp_pick_13_ind")]
    [StringLength(1)]
    public string? RespPick13Ind { get; set; }

    [Column("resp_pick_14_ind")]
    [StringLength(1)]
    public string? RespPick14Ind { get; set; }

    [Column("resp_pick_15_ind")]
    [StringLength(1)]
    public string? RespPick15Ind { get; set; }

    [Column("resp_datetime", TypeName = "datetime")]
    public DateTime? RespDatetime { get; set; }

    [Column("corrected_entry_ind")]
    [StringLength(1)]
    public string? CorrectedEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("question_no")]
    [StringLength(5)]
    public string? QuestionNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [ForeignKey("PtId, PtVisitId, QstrName, QstrId")]
    [InverseProperty("PtResp")]
    public virtual PtRespHdr PtRespHdr { get; set; } = null!;
}
