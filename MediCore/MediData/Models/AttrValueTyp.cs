using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("attr_value_typ")]
public partial class AttrValueTyp
{
    [Key]
    [Column("attr_value_typ")]
    public int AttrValueTyp1 { get; set; }

    [Column("attr_cat_typ")]
    public int AttrCatTyp { get; set; }

    [Column("attr_value_desc")]
    [StringLength(50)]
    public string AttrValueDesc { get; set; } = null!;

    [Column("attr_value_dsp")]
    [StringLength(10)]
    public string AttrValueDsp { get; set; } = null!;

    [Column("attr_value_seq_no")]
    public int? AttrValueSeqNo { get; set; }

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
