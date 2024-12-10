using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("allergy_typ")]
public partial class AllergyTyp
{
    [Key]
    [Column("allergy_typ")]
    public int AllergyTyp1 { get; set; }

    [Column("allergy_desc")]
    [StringLength(40)]
    public string AllergyDesc { get; set; } = null!;

    [Column("allergy_cd")]
    [StringLength(5)]
    public string? AllergyCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("AllergyTypNavigation")]
    public virtual ICollection<PtAllergy> PtAllergy { get; set; } = new List<PtAllergy>();

    [InverseProperty("AllergyTypNavigation")]
    public virtual ICollection<PtAllergyExternal> PtAllergyExternal { get; set; } = new List<PtAllergyExternal>();
}
