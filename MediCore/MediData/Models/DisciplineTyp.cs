using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("discipline_typ")]
public partial class DisciplineTyp
{
    [Key]
    [Column("discipline_typ")]
    public int DisciplineTyp1 { get; set; }

    [Column("discipline_desc")]
    [StringLength(40)]
    public string DisciplineDesc { get; set; } = null!;

    [Column("discipline_display")]
    [StringLength(40)]
    public string DisciplineDisplay { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("DisciplineTypNavigation")]
    public virtual ICollection<Stkh> Stkh { get; set; } = new List<Stkh>();

    [InverseProperty("DisciplineTypNavigation")]
    public virtual ICollection<Userid> Userid { get; set; } = new List<Userid>();
}
