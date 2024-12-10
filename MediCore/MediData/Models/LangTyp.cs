using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("lang_typ")]
public partial class LangTyp
{
    [Key]
    [Column("lang_typ")]
    public int LangTyp1 { get; set; }

    [Column("lang_desc")]
    [StringLength(50)]
    public string LangDesc { get; set; } = null!;

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

    [Column("web_active_ind")]
    [StringLength(1)]
    public string? WebActiveInd { get; set; }

    [Column("optx_active_ind")]
    [StringLength(1)]
    public string? OptxActiveInd { get; set; }

    [InverseProperty("LangTypNavigation")]
    public virtual ICollection<IntfMode> IntfMode { get; set; } = new List<IntfMode>();
}
