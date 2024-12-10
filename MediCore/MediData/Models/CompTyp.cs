using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("comp_typ")]
public partial class CompTyp
{
    [Key]
    [Column("comp_typ")]
    public int CompTyp1 { get; set; }

    [Column("comp_desc")]
    [StringLength(40)]
    public string CompDesc { get; set; } = null!;

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

    [InverseProperty("CompTypNavigation")]
    public virtual ICollection<TestComp> TestComp { get; set; } = new List<TestComp>();
}
