using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAeId")]
[Table("pt_ae")]
public partial class PtAe
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_ae_id")]
    public int PtAeId { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [Column("clinically_sig_ind")]
    [StringLength(1)]
    public string? ClinicallySigInd { get; set; }

    [Column("serious_ind")]
    [StringLength(1)]
    public string? SeriousInd { get; set; }

    [Column("hospitalized_ind")]
    [StringLength(1)]
    public string? HospitalizedInd { get; set; }

    [Column("expected_ind")]
    [StringLength(1)]
    public string? ExpectedInd { get; set; }

    [Column("seq_no")]
    [StringLength(10)]
    public string? SeqNo { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("tr_cs_cert_typ")]
    public int? TrCsCertTyp { get; set; }

    [Column("tr_cs_typ")]
    public int? TrCsTyp { get; set; }

    [Column("tr_grade")]
    public int? TrGrade { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("pt_ae_cmt")]
    [StringLength(255)]
    public string? PtAeCmt { get; set; }

    [Column("death_ind")]
    [StringLength(1)]
    public string? DeathInd { get; set; }

    [Column("reportable_ind")]
    [StringLength(1)]
    public string? ReportableInd { get; set; }

    [Column("reported_ind")]
    [StringLength(1)]
    public string? ReportedInd { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
