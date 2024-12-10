using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("allergy_resp_typ")]
public partial class AllergyRespTyp
{
    [Key]
    [Column("resp_typ")]
    public int RespTyp { get; set; }

    [Column("resp_desc")]
    [StringLength(40)]
    public string RespDesc { get; set; } = null!;

    [Column("medi_symptom_id")]
    public int? MediSymptomId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("RespTypNavigation")]
    public virtual ICollection<PtAllergyResp> PtAllergyResp { get; set; } = new List<PtAllergyResp>();

    [InverseProperty("RespTypNavigation")]
    public virtual ICollection<PtAllergyRespExternal> PtAllergyRespExternal { get; set; } = new List<PtAllergyRespExternal>();
}
