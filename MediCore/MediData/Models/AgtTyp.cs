using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_typ")]
public partial class AgtTyp
{
    [Key]
    [Column("agt_typ")]
    public int AgtTyp1 { get; set; }

    [Column("agt_typ_desc")]
    [StringLength(40)]
    public string? AgtTypDesc { get; set; }

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

    [InverseProperty("AgtTypNavigation")]
    public virtual ICollection<AgtName> AgtName { get; set; } = new List<AgtName>();
}
