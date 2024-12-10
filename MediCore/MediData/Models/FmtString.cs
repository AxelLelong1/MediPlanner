using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fmt_string")]
public partial class FmtString
{
    [Key]
    [Column("fmt_string_id")]
    public int FmtStringId { get; set; }

    [Column("fmt_string_desc")]
    [StringLength(40)]
    public string FmtStringDesc { get; set; } = null!;

    [Column("fmt_string_value")]
    [StringLength(40)]
    public string? FmtStringValue { get; set; }

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

    [InverseProperty("FmtString")]
    public virtual ICollection<FmtField> FmtField { get; set; } = new List<FmtField>();
}
