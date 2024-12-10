using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_user_defined")]
public partial class PtUserDefined
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("user_defined_1")]
    [StringLength(16)]
    public string? UserDefined1 { get; set; }

    [Column("user_defined_2")]
    [StringLength(16)]
    public string? UserDefined2 { get; set; }

    [Column("user_defined_3")]
    [StringLength(16)]
    public string? UserDefined3 { get; set; }

    [Column("user_defined_4")]
    [StringLength(16)]
    public string? UserDefined4 { get; set; }

    [Column("user_defined_5")]
    [StringLength(16)]
    public string? UserDefined5 { get; set; }

    [Column("user_defined_6")]
    [StringLength(16)]
    public string? UserDefined6 { get; set; }

    [Column("user_defined_7")]
    [StringLength(16)]
    public string? UserDefined7 { get; set; }

    [Column("user_defined_8")]
    [StringLength(16)]
    public string? UserDefined8 { get; set; }

    [Column("user_defined_9")]
    [StringLength(16)]
    public string? UserDefined9 { get; set; }

    [Column("user_defined_10")]
    [StringLength(16)]
    public string? UserDefined10 { get; set; }

    [Column("user_defined_11")]
    [StringLength(16)]
    public string? UserDefined11 { get; set; }

    [Column("user_defined_12")]
    [StringLength(16)]
    public string? UserDefined12 { get; set; }

    [Column("user_defined_13")]
    [StringLength(16)]
    public string? UserDefined13 { get; set; }

    [Column("user_defined_14")]
    [StringLength(16)]
    public string? UserDefined14 { get; set; }

    [Column("user_defined_15")]
    [StringLength(16)]
    public string? UserDefined15 { get; set; }

    [Column("user_defined_16")]
    [StringLength(16)]
    public string? UserDefined16 { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

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
}
