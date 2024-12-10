using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("religions")]
public partial class Religions
{
    [Key]
    [Column("religion_id")]
    public int ReligionId { get; set; }

    [Column("religion_desc")]
    [StringLength(50)]
    public string ReligionDesc { get; set; } = null!;

    [Column("religion_cd")]
    [StringLength(5)]
    public string? ReligionCd { get; set; }

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
}
