using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("symbol_cd")]
public partial class SymbolCd
{
    [Key]
    [Column("symbol_cd")]
    [StringLength(3)]
    public string SymbolCd1 { get; set; } = null!;

    [Column("symbol_desc")]
    [StringLength(40)]
    public string SymbolDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("SymbolCdNavigation")]
    public virtual ICollection<TestResult> TestResult { get; set; } = new List<TestResult>();
}
