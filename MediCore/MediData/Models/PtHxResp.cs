using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "HdrTyp", "QuestionNo", "TransLogTstamp")]
[Table("pt_hx_resp")]
public partial class PtHxResp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("hdr_typ")]
    public int HdrTyp { get; set; }

    [Key]
    [Column("question_no")]
    public int QuestionNo { get; set; }

    [Column("resp_ind")]
    [StringLength(1)]
    public string RespInd { get; set; } = null!;

    [Column("resp_date", TypeName = "datetime")]
    public DateTime? RespDate { get; set; }

    [Column("resp_no")]
    public int? RespNo { get; set; }

    [Column("resp_string")]
    public string? RespString { get; set; }

    [Column("resp_boolean")]
    [StringLength(1)]
    public string? RespBoolean { get; set; }

    [Column("resp_radio")]
    public int? RespRadio { get; set; }

    [Column("resp_start")]
    public int? RespStart { get; set; }

    [Column("resp_end")]
    public int? RespEnd { get; set; }

    [Column("valid_entry")]
    [StringLength(1)]
    public string? ValidEntry { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("hx_of_ind")]
    [StringLength(1)]
    public string? HxOfInd { get; set; }

    [Column("hx_date", TypeName = "datetime")]
    public DateTime? HxDate { get; set; }

    [ForeignKey("HdrTyp, QuestionNo")]
    [InverseProperty("PtHxResp")]
    public virtual HxQuestion HxQuestion { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtHxResp")]
    public virtual Pt Pt { get; set; } = null!;
}
