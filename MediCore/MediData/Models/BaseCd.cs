using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("base_cd")]
public partial class BaseCd
{
    [Key]
    [Column("base_cd")]
    [StringLength(3)]
    public string BaseCd1 { get; set; } = null!;

    [Column("base_cls_typ")]
    public int BaseClsTyp { get; set; }

    [Column("base_desc")]
    [StringLength(40)]
    public string BaseDesc { get; set; } = null!;

    [Column("seq_no")]
    public int? SeqNo { get; set; }

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
