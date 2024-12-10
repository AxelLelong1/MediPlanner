using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("spcmn_action")]
public partial class SpcmnAction
{
    [Key]
    [Column("spcmn_action_id")]
    public int SpcmnActionId { get; set; }

    [Column("spcmn_action_desc")]
    [StringLength(40)]
    public string SpcmnActionDesc { get; set; } = null!;

    [Column("spcmn_action_cd")]
    [StringLength(5)]
    public string? SpcmnActionCd { get; set; }

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

    [InverseProperty("SpcmnAction")]
    public virtual ICollection<TestSpcmn> TestSpcmn { get; set; } = new List<TestSpcmn>();
}
