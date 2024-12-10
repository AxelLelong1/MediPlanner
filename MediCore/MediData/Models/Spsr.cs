using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("spsr")]
public partial class Spsr
{
    [Key]
    [Column("spsr")]
    public int Spsr1 { get; set; }

    [Column("spsr_desc")]
    [StringLength(40)]
    public string SpsrDesc { get; set; } = null!;

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

    [InverseProperty("OrigAuthorNavigation")]
    public virtual ICollection<ClsScheme> ClsSchemeOrigAuthorNavigation { get; set; } = new List<ClsScheme>();

    [InverseProperty("SchemeAuthorNavigation")]
    public virtual ICollection<ClsScheme> ClsSchemeSchemeAuthorNavigation { get; set; } = new List<ClsScheme>();

    [InverseProperty("GsAuthorNavigation")]
    public virtual ICollection<GradingSchemes> GradingSchemesGsAuthorNavigation { get; set; } = new List<GradingSchemes>();

    [InverseProperty("OriginalGsAuthorNavigation")]
    public virtual ICollection<GradingSchemes> GradingSchemesOriginalGsAuthorNavigation { get; set; } = new List<GradingSchemes>();

    [InverseProperty("OriginalSpsrNavigation")]
    public virtual ICollection<TxPln> TxPlnOriginalSpsrNavigation { get; set; } = new List<TxPln>();

    [InverseProperty("SpsrNavigation")]
    public virtual ICollection<TxPln> TxPlnSpsrNavigation { get; set; } = new List<TxPln>();
}
