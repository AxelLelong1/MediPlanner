using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("focus_status_typ")]
public partial class FocusStatusTyp
{
    [Key]
    [Column("focus_status_typ")]
    public int FocusStatusTyp1 { get; set; }

    [Column("focus_status_desc")]
    [StringLength(30)]
    public string FocusStatusDesc { get; set; } = null!;

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

    [InverseProperty("FocusStatusTypNavigation")]
    public virtual ICollection<PtTpFocusStatus> PtTpFocusStatus { get; set; } = new List<PtTpFocusStatus>();
}
