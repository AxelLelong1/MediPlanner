using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtMedId")]
[Table("pt_med_hx")]
public partial class PtMedHx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_med_id")]
    public int PtMedId { get; set; }

    [Column("prob_desc")]
    [StringLength(255)]
    public string? ProbDesc { get; set; }

    [Column("prob_id")]
    public int? ProbId { get; set; }

    [Column("prob_details")]
    public string? ProbDetails { get; set; }

    [Column("dx_date", TypeName = "datetime")]
    public DateTime? DxDate { get; set; }

    [Column("active_dx_ind")]
    [StringLength(1)]
    public string? ActiveDxInd { get; set; }

    [Column("tx_ind")]
    [StringLength(1)]
    public string? TxInd { get; set; }

    [Column("tx_desc")]
    [StringLength(100)]
    public string? TxDesc { get; set; }

    [Column("icd_cd")]
    [StringLength(16)]
    public string? IcdCd { get; set; }

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

    [Column("pt_dx_id")]
    public int? PtDxId { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("med_date_cd")]
    public int? MedDateCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("procedure_age")]
    public int? ProcedureAge { get; set; }

    [Column("snomed_ct_cd")]
    public long? SnomedCtCd { get; set; }
}
