using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("unavl_dow")]
public partial class UnavlDow
{
    [Key]
    [Column("unavl_dow")]
    public int UnavlDow1 { get; set; }

    [Column("unavl_desc")]
    [StringLength(40)]
    public string UnavlDesc { get; set; } = null!;

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

    [InverseProperty("ProfUnavlDowNavigation")]
    public virtual ICollection<ProfUnavl> ProfUnavl { get; set; } = new List<ProfUnavl>();

    [InverseProperty("PtUnavlDowNavigation")]
    public virtual ICollection<PtUnavl> PtUnavl { get; set; } = new List<PtUnavl>();
}
