using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "ProcedureId")]
[Table("pt_procedure")]
public partial class PtProcedure
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("procedure_id")]
    public int ProcedureId { get; set; }

    [Column("icd_cd")]
    [StringLength(16)]
    public string? IcdCd { get; set; }

    [Column("procedure_date", TypeName = "datetime")]
    public DateTime? ProcedureDate { get; set; }

    [Column("procedure_name")]
    [StringLength(255)]
    public string? ProcedureName { get; set; }

    [Column("valid_entry")]
    [StringLength(1)]
    public string? ValidEntry { get; set; }

    [Column("procedure_desc")]
    public string? ProcedureDesc { get; set; }

    [Column("procedure_outcome")]
    public string? ProcedureOutcome { get; set; }

    [Column("date_approx_ind")]
    [StringLength(1)]
    public string? DateApproxInd { get; set; }

    [Column("procedure_date_cd")]
    public int? ProcedureDateCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("proc_id")]
    public int? ProcId { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("procedure_age")]
    public int? ProcedureAge { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("snomed_ct_cd")]
    public long? SnomedCtCd { get; set; }
}
