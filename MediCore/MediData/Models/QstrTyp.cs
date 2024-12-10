using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qstr_typ")]
public partial class QstrTyp
{
    [Key]
    [Column("qstr_typ")]
    public int QstrTyp1 { get; set; }

    [Column("qstr_desc")]
    [StringLength(40)]
    public string QstrDesc { get; set; } = null!;

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

    [InverseProperty("QstrTypNavigation")]
    public virtual ICollection<Qstr> Qstr { get; set; } = new List<Qstr>();
}
