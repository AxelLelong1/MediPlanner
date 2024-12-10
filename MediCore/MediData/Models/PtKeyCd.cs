using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_key_cd")]
public partial class PtKeyCd
{
    [Key]
    [Column("pt_key_cd")]
    public int PtKeyCd1 { get; set; }

    [Column("pt_key_desc")]
    [StringLength(40)]
    public string PtKeyDesc { get; set; } = null!;

    [Column("pt_key_scope_typ")]
    public int PtKeyScopeTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("PtKeyCdNavigation")]
    public virtual ICollection<InstPtKeyCd> InstPtKeyCd { get; set; } = new List<InstPtKeyCd>();

    [InverseProperty("PtKeyCdNavigation")]
    public virtual ICollection<PtInstKey> PtInstKey { get; set; } = new List<PtInstKey>();

    [ForeignKey("PtKeyScopeTyp")]
    [InverseProperty("PtKeyCd")]
    public virtual PtKeyScopeTyp PtKeyScopeTypNavigation { get; set; } = null!;
}
