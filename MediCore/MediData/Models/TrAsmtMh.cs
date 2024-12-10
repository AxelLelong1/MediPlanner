using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtTrAsmtId", "RevisionNo")]
[Table("tr_asmt_mh")]
public partial class TrAsmtMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_tr_asmt_id")]
    public int PtTrAsmtId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("tr_asmt_typ")]
    public int TrAsmtTyp { get; set; }

    [Column("date_time_asmt", TypeName = "datetime")]
    public DateTime DateTimeAsmt { get; set; }

    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName { get; set; } = null!;

    [Column("tr_grade")]
    public int TrGrade { get; set; }

    [Column("grade")]
    public int? Grade { get; set; }

    [Column("tr_reason")]
    public string? TrReason { get; set; }

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

    [Column("tr_asmt_hdr_id")]
    public int? TrAsmtHdrId { get; set; }

    [Column("tr_cs_cert_typ")]
    public int? TrCsCertTyp { get; set; }

    [Column("tr_cs_typ")]
    public int? TrCsTyp { get; set; }

    [Column("corrected_entry_ind")]
    [StringLength(1)]
    public string? CorrectedEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("ae_ind")]
    [StringLength(1)]
    public string? AeInd { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [Column("test_result_id")]
    public int? TestResultId { get; set; }

    [Column("tr_sub_comp_name")]
    [StringLength(60)]
    public string? TrSubCompName { get; set; }

    [Column("tr_sub_comp_grade")]
    public int? TrSubCompGrade { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("tr_asmt_start_date", TypeName = "datetime")]
    public DateTime? TrAsmtStartDate { get; set; }

    [Column("tr_asmt_end_date", TypeName = "datetime")]
    public DateTime? TrAsmtEndDate { get; set; }
}
