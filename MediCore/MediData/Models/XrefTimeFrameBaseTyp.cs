using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TimeFrameTyp", "BaseTyp", "BaseClsTyp")]
[Table("xref_time_frame_base_typ")]
public partial class XrefTimeFrameBaseTyp
{
    [Key]
    [Column("time_frame_typ")]
    public int TimeFrameTyp { get; set; }

    [Key]
    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Key]
    [Column("base_cls_typ")]
    public int BaseClsTyp { get; set; }

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
}
