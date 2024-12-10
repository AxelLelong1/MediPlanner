using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ucum")]
public partial class Ucum
{
    [Key]
    [Column("ucum_id")]
    public int UcumId { get; set; }

    [Column("code")]
    [StringLength(40)]
    public string Code { get; set; } = null!;

    [Column("code_name")]
    [StringLength(255)]
    public string CodeName { get; set; } = null!;

    [Column("code_preferred_name")]
    [StringLength(255)]
    public string? CodePreferredName { get; set; }

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

    [InverseProperty("Ucum")]
    public virtual ICollection<XrefUcumUnit> XrefUcumUnit { get; set; } = new List<XrefUcumUnit>();
}
