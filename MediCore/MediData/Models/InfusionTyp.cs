using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("infusion_typ")]
public partial class InfusionTyp
{
    [Key]
    [Column("infusion_typ")]
    public int InfusionTyp1 { get; set; }

    [Column("infusion_desc")]
    [StringLength(40)]
    public string? InfusionDesc { get; set; }

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

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<AgtRx> AgtRx { get; set; } = new List<AgtRx>();

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<InfusionDetails> InfusionDetails { get; set; } = new List<InfusionDetails>();

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<PtIvTherapy> PtIvTherapy { get; set; } = new List<PtIvTherapy>();

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<PtTpAgt> PtTpAgt { get; set; } = new List<PtTpAgt>();

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<PtTpIvTherapy> PtTpIvTherapy { get; set; } = new List<PtTpIvTherapy>();

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<TpAgt> TpAgt { get; set; } = new List<TpAgt>();

    [InverseProperty("InfusionTypNavigation")]
    public virtual ICollection<TpIvTherapy> TpIvTherapy { get; set; } = new List<TpIvTherapy>();
}
