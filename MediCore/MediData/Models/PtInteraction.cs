using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_interaction")]
public partial class PtInteraction
{
    [Key]
    [Column("pt_interaction_id")]
    public int PtInteractionId { get; set; }

    [Column("pt_interaction_desc")]
    [StringLength(40)]
    public string PtInteractionDesc { get; set; } = null!;

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

    [InverseProperty("PtInteraction")]
    public virtual ICollection<PtTpTperiod> PtTpTperiod { get; set; } = new List<PtTpTperiod>();
}
