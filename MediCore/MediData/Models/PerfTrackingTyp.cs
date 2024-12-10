using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("perf_tracking_typ")]
public partial class PerfTrackingTyp
{
    [Key]
    [Column("perf_tracking_typ_id")]
    public int PerfTrackingTypId { get; set; }

    [Column("perf_tracking_typ_desc")]
    [StringLength(50)]
    public string? PerfTrackingTypDesc { get; set; }

    [Column("perf_tracking_typ_txt")]
    [StringLength(256)]
    public string? PerfTrackingTypTxt { get; set; }

    [Column("display_order")]
    public int? DisplayOrder { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
