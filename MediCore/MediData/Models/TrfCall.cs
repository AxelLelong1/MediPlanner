using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("trf_call")]
public partial class TrfCall
{
    [Key]
    [Column("call_id")]
    public int CallId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("trf_fnctn")]
    [StringLength(30)]
    public string TrfFnctn { get; set; } = null!;

    [Column("call_time")]
    [StringLength(8)]
    public string CallTime { get; set; } = null!;

    [Column("call_day")]
    public int? CallDay { get; set; }

    [Column("call_day_no")]
    public int? CallDayNo { get; set; }

    [Column("call_dt_no")]
    public int? CallDtNo { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("TrfCall")]
    public virtual Inst Inst { get; set; } = null!;
}
