using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpClsTypFrom", "TpClsValueFrom", "TpClsTypTo", "TpClsValueTo")]
[Table("xref_tp_cls")]
public partial class XrefTpCls
{
    [Key]
    [Column("tp_cls_typ_from")]
    public int TpClsTypFrom { get; set; }

    [Key]
    [Column("tp_cls_value_from")]
    public int TpClsValueFrom { get; set; }

    [Key]
    [Column("tp_cls_typ_to")]
    public int TpClsTypTo { get; set; }

    [Key]
    [Column("tp_cls_value_to")]
    public int TpClsValueTo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
