using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("user_prefer_cd")]
public partial class UserPreferCd
{
    [Key]
    [Column("user_prefer_cd")]
    public int UserPreferCd1 { get; set; }

    [Column("user_prefer_desc")]
    [StringLength(255)]
    public string UserPreferDesc { get; set; } = null!;

    [Column("data_typ")]
    [StringLength(2)]
    public string? DataTyp { get; set; }

    [Column("default_value")]
    [StringLength(255)]
    public string? DefaultValue { get; set; }

    [Column("visible_ind")]
    [StringLength(1)]
    public string? VisibleInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("section_name")]
    [StringLength(30)]
    public string? SectionName { get; set; }

    [Column("mgr_ind")]
    [StringLength(1)]
    public string? MgrInd { get; set; }

    [Column("pln_ind")]
    [StringLength(1)]
    public string? PlnInd { get; set; }

    [Column("sec_ind")]
    [StringLength(1)]
    public string? SecInd { get; set; }
}
