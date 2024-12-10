using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pref_agt_name_log")]
public partial class PrefAgtNameLog
{
    [Key]
    [Column("pref_agt_name_log_id")]
    public int PrefAgtNameLogId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("pref_agt_name_old")]
    [StringLength(50)]
    public string PrefAgtNameOld { get; set; } = null!;

    [Column("pref_agt_name_new")]
    [StringLength(50)]
    public string PrefAgtNameNew { get; set; } = null!;

    [Column("agt_cls_desc")]
    [StringLength(20)]
    public string? AgtClsDesc { get; set; }

    [Column("update_quarter", TypeName = "datetime")]
    public DateTime UpdateQuarter { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
