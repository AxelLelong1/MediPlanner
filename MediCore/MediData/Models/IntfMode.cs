using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfMode1", "LangTyp")]
[Table("intf_mode")]
public partial class IntfMode
{
    [Key]
    [Column("intf_mode")]
    public int IntfMode1 { get; set; }

    [Key]
    [Column("lang_typ")]
    public int LangTyp { get; set; }

    [Column("intf_mode_desc")]
    [StringLength(100)]
    public string? IntfModeDesc { get; set; }

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

    [ForeignKey("LangTyp")]
    [InverseProperty("IntfMode")]
    public virtual LangTyp LangTypNavigation { get; set; } = null!;
}
