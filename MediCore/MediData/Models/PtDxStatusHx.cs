using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtDxId", "PtDxStatusId")]
[Table("pt_dx_status_hx")]
public partial class PtDxStatusHx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_dx_id")]
    public int PtDxId { get; set; }

    [Key]
    [Column("pt_dx_status_id")]
    public int PtDxStatusId { get; set; }

    [Column("resolution_typ")]
    public int? ResolutionTyp { get; set; }

    [Column("resolution_date", TypeName = "datetime")]
    public DateTime? ResolutionDate { get; set; }

    [Column("resolution_desc")]
    [StringLength(255)]
    public string? ResolutionDesc { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("resolution_date_cd")]
    public int? ResolutionDateCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
