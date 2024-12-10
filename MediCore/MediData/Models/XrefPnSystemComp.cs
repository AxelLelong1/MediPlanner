using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FromCompId", "ToCompId")]
[Table("xref_pn_system_comp")]
public partial class XrefPnSystemComp
{
    [Key]
    [Column("from_comp_id")]
    [StringLength(10)]
    public string FromCompId { get; set; } = null!;

    [Key]
    [Column("to_comp_id")]
    [StringLength(10)]
    public string ToCompId { get; set; } = null!;

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
}
