using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "IntvId", "CourseNo")]
[Table("pt_tp_agt_course")]
public partial class PtTpAgtCourse
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Key]
    [Column("course_no")]
    public int CourseNo { get; set; }

    [Column("admn_dose", TypeName = "numeric(11, 4)")]
    public decimal? AdmnDose { get; set; }

    [Column("admn_frq_cd")]
    public int? AdmnFrqCd { get; set; }

    [Column("admn_frq_x")]
    public int? AdmnFrqX { get; set; }

    [Column("admn_frq_unit")]
    public int? AdmnFrqUnit { get; set; }

    [Column("admn_dur")]
    public int? AdmnDur { get; set; }

    [Column("admn_dur_unit")]
    public int? AdmnDurUnit { get; set; }

    [Column("prn_ind")]
    [StringLength(1)]
    public string? PrnInd { get; set; }

    [Column("prn_repeat_ind")]
    [StringLength(1)]
    public string? PrnRepeatInd { get; set; }

    [Column("dow_frq_unit")]
    public int? DowFrqUnit { get; set; }

    [Column("week_frq_unit")]
    public int? WeekFrqUnit { get; set; }

    [Column("course_desc")]
    [StringLength(255)]
    public string? CourseDesc { get; set; }

    [Column("dispense_qty")]
    public int? DispenseQty { get; set; }

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

    [Column("dispense_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispenseVol { get; set; }

    [Column("dispense_unit")]
    public int? DispenseUnit { get; set; }

    [Column("admn_frq_upper_x")]
    public int? AdmnFrqUpperX { get; set; }

    [Column("prn_reason_typ")]
    public int? PrnReasonTyp { get; set; }

    [ForeignKey("PtId, DateTpInit, IntvId")]
    [InverseProperty("PtTpAgtCourse")]
    public virtual PtTpAgt PtTpAgt { get; set; } = null!;
}
