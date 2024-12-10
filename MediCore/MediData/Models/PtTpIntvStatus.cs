using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "IntvId", "StatusId")]
[Table("pt_tp_intv_status")]
public partial class PtTpIntvStatus
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
    [Column("status_id")]
    public int StatusId { get; set; }

    [Column("status_cat_id")]
    public int StatusCatId { get; set; }

    [Column("status_value_id")]
    public int StatusValueId { get; set; }

    [Column("status_duration")]
    public int? StatusDuration { get; set; }

    [Column("start_tstamp", TypeName = "datetime")]
    public DateTime? StartTstamp { get; set; }

    [Column("end_tstamp", TypeName = "datetime")]
    public DateTime? EndTstamp { get; set; }

    [Column("current_entry_ind")]
    [StringLength(1)]
    public string? CurrentEntryInd { get; set; }

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

    [ForeignKey("StatusCatId, StatusValueId")]
    [InverseProperty("PtTpIntvStatus")]
    public virtual StatusCatValue StatusCatValue { get; set; } = null!;
}
