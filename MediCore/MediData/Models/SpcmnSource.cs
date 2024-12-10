using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("spcmn_source")]
public partial class SpcmnSource
{
    [Key]
    [Column("spcmn_source_id")]
    public int SpcmnSourceId { get; set; }

    [Column("spcmn_source_desc")]
    [StringLength(30)]
    public string SpcmnSourceDesc { get; set; } = null!;

    [Column("spcmn_source_cd")]
    [StringLength(5)]
    public string? SpcmnSourceCd { get; set; }

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

    [InverseProperty("SpcmnSource")]
    public virtual ICollection<TestSpcmn> TestSpcmn { get; set; } = new List<TestSpcmn>();
}
