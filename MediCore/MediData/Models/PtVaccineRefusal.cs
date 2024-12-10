using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("VaccineRefusalId", "PtId")]
[Table("pt_vaccine_refusal")]
[Index("PtId", Name = "nc1_pt_vaccine_refusal")]
public partial class PtVaccineRefusal
{
    [Key]
    [Column("vaccine_refusal_id")]
    public int VaccineRefusalId { get; set; }

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string DrugDescId { get; set; } = null!;

    [Column("vaccine_refusal_date", TypeName = "datetime")]
    public DateTime VaccineRefusalDate { get; set; }

    [Column("refusal_reason_id")]
    public int RefusalReasonId { get; set; }

    [Column("refusal_reason_cmt")]
    [StringLength(256)]
    public string? RefusalReasonCmt { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }
}
