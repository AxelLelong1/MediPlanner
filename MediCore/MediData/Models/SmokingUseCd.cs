using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("smoking_use_cd")]
public partial class SmokingUseCd
{
    [Key]
    [Column("smoking_use_cd")]
    [StringLength(1)]
    public string SmokingUseCd1 { get; set; } = null!;

    [Column("smoking_use_desc")]
    [StringLength(50)]
    public string? SmokingUseDesc { get; set; }

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

    [Column("snomed_ct_cd")]
    public long? SnomedCtCd { get; set; }
}
