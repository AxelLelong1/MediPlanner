using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtCldrId")]
[Table("pt_cldr")]
[Index("PtId", "PtCldrDate", Name = "nc1_pt_cldr")]
public partial class PtCldr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_cldr_id")]
    public int PtCldrId { get; set; }

    [Column("pt_cldr_desc")]
    [StringLength(255)]
    public string? PtCldrDesc { get; set; }

    [Column("pt_cldr_date", TypeName = "datetime")]
    public DateTime PtCldrDate { get; set; }

    [Column("pt_interaction_id")]
    public int PtInteractionId { get; set; }

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

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("order_ind")]
    [StringLength(1)]
    public string? OrderInd { get; set; }
}
