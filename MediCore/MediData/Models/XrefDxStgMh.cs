using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtStageId", "PtDxId", "RevisionNo")]
[Table("xref_dx_stg_mh")]
public partial class XrefDxStgMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_stage_id")]
    public int PtStageId { get; set; }

    [Key]
    [Column("pt_dx_id")]
    public int PtDxId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("cur_stg_ind")]
    [StringLength(1)]
    public string? CurStgInd { get; set; }

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

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
