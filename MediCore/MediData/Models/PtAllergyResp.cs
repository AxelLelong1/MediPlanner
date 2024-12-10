using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AllergyId", "AllergyRespId")]
[Table("pt_allergy_resp")]
public partial class PtAllergyResp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("allergy_id")]
    public int AllergyId { get; set; }

    [Key]
    [Column("allergy_resp_id")]
    public int AllergyRespId { get; set; }

    [Column("resp_typ")]
    public int RespTyp { get; set; }

    [Column("resp")]
    [StringLength(255)]
    public string? Resp { get; set; }

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("severity_id")]
    public int? SeverityId { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("severity_level")]
    public int? SeverityLevel { get; set; }

    [Column("snomed_ct_cd")]
    public long? SnomedCtCd { get; set; }

    [ForeignKey("PtId, AllergyId")]
    [InverseProperty("PtAllergyResp")]
    public virtual PtAllergy PtAllergy { get; set; } = null!;

    [ForeignKey("RespTyp")]
    [InverseProperty("PtAllergyResp")]
    public virtual AllergyRespTyp RespTypNavigation { get; set; } = null!;
}
