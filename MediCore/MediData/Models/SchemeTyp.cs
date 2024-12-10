using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("scheme_typ")]
public partial class SchemeTyp
{
    [Key]
    [Column("scheme_typ")]
    public int SchemeTyp1 { get; set; }

    [Column("scheme_desc")]
    [StringLength(40)]
    public string SchemeDesc { get; set; } = null!;

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

    [InverseProperty("SchemeTypNavigation")]
    public virtual ICollection<ClsScheme> ClsScheme { get; set; } = new List<ClsScheme>();

    [InverseProperty("SchemeTypNavigation")]
    public virtual ICollection<InstScheme> InstScheme { get; set; } = new List<InstScheme>();

    [InverseProperty("SchemeTypNavigation")]
    public virtual ICollection<TpScheme> TpScheme { get; set; } = new List<TpScheme>();
}
