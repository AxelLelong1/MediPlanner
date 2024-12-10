using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("prof_reltn")]
public partial class ProfReltn
{
    [Key]
    [Column("prof_reltn")]
    public int ProfReltn1 { get; set; }

    [Column("prof_reltn_desc")]
    [StringLength(40)]
    public string? ProfReltnDesc { get; set; }

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

    [InverseProperty("ProfReltnNavigation")]
    public virtual ICollection<PtProf> PtProf { get; set; } = new List<PtProf>();
}
