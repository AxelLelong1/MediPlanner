using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AgtScreeningId")]
[Table("pt_agt_screening_detail")]
public partial class PtAgtScreeningDetail
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("agt_screening_id")]
    public int AgtScreeningId { get; set; }

    [Column("interaction_txt")]
    public string? InteractionTxt { get; set; }

    [Column("contra_txt")]
    public string? ContraTxt { get; set; }

    [Column("allergy_txt")]
    public string? AllergyTxt { get; set; }

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

    [ForeignKey("PtId, AgtScreeningId")]
    [InverseProperty("PtAgtScreeningDetail")]
    public virtual PtAgtScreening PtAgtScreening { get; set; } = null!;
}
