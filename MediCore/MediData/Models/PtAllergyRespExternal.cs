using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAllergyExternalId", "PtAllergyRespExternalId")]
[Table("pt_allergy_resp_external")]
public partial class PtAllergyRespExternal
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_allergy_external_id")]
    public int PtAllergyExternalId { get; set; }

    [Key]
    [Column("pt_allergy_resp_external_id")]
    public int PtAllergyRespExternalId { get; set; }

    [Column("resp_typ")]
    public int? RespTyp { get; set; }

    [Column("resp")]
    [StringLength(255)]
    public string? Resp { get; set; }

    [Column("severity_id")]
    public int? SeverityId { get; set; }

    [Column("snomed_ct_cd")]
    public long? SnomedCtCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtAllergyRespExternal")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("PtId, PtAllergyExternalId")]
    [InverseProperty("PtAllergyRespExternal")]
    public virtual PtAllergyExternal PtAllergyExternal { get; set; } = null!;

    [ForeignKey("RespTyp")]
    [InverseProperty("PtAllergyRespExternal")]
    public virtual AllergyRespTyp? RespTypNavigation { get; set; }
}
