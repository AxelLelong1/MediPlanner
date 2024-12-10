using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("time_frame")]
public partial class TimeFrame
{
    [Key]
    [Column("time_frame_typ")]
    public int TimeFrameTyp { get; set; }

    [Column("time_frame_desc")]
    [StringLength(40)]
    public string TimeFrameDesc { get; set; } = null!;

    [Column("time_frame_dur", TypeName = "numeric(11, 2)")]
    public decimal? TimeFrameDur { get; set; }

    [Column("time_frame_dur_unit")]
    public int? TimeFrameDurUnit { get; set; }

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

    [Column("display_order")]
    public int? DisplayOrder { get; set; }
}
