using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fcn_detail")]
public partial class FcnDetail
{
    [Key]
    [Column("fcn_id")]
    public int FcnId { get; set; }

    [Column("fcn_typ")]
    public int FcnTyp { get; set; }

    [Column("fcn_detail_name")]
    [StringLength(30)]
    public string FcnDetailName { get; set; } = null!;

    [Column("fcn_desc")]
    [StringLength(255)]
    public string FcnDesc { get; set; } = null!;

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    [Column("age_start")]
    public int? AgeStart { get; set; }

    [Column("age_end")]
    public int? AgeEnd { get; set; }

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

    [ForeignKey("FcnTyp")]
    [InverseProperty("FcnDetail")]
    public virtual FcnTyp FcnTypNavigation { get; set; } = null!;
}
