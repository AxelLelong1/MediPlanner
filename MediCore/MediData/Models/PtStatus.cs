using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtStatusId")]
[Table("pt_status")]
public partial class PtStatus
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_status_id")]
    public int PtStatusId { get; set; }

    [Column("pt_status_typ_id")]
    public int PtStatusTypId { get; set; }

    [Column("status_date", TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [Column("status_note")]
    public string? StatusNote { get; set; }

    [Column("cur_value_ind")]
    [StringLength(1)]
    public string CurValueInd { get; set; } = null!;

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

    [ForeignKey("PtStatusTypId")]
    [InverseProperty("PtStatus")]
    public virtual PtStatusTyp PtStatusTyp { get; set; } = null!;
}
