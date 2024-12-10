using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtIvId")]
[Table("pt_iv")]
public partial class PtIv
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_iv_id")]
    public int PtIvId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Column("iv_date", TypeName = "datetime")]
    public DateTime IvDate { get; set; }

    [Column("iv_start_date", TypeName = "datetime")]
    public DateTime? IvStartDate { get; set; }

    [Column("iv_end_date", TypeName = "datetime")]
    public DateTime? IvEndDate { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("IvQstrId")]
    [InverseProperty("PtIv")]
    public virtual IvQstr IvQstr { get; set; } = null!;

    [InverseProperty("PtIv")]
    public virtual ICollection<PtIvResp> PtIvResp { get; set; } = new List<PtIvResp>();

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("PtIv")]
    public virtual PtVisit PtVisit { get; set; } = null!;
}
