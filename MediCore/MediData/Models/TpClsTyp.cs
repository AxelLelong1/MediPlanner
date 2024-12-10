using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tp_cls_typ")]
public partial class TpClsTyp
{
    [Key]
    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Column("tp_cls_typ_desc")]
    [StringLength(40)]
    public string TpClsTypDesc { get; set; } = null!;

    [Column("tp_cls_typ_seq")]
    public int? TpClsTypSeq { get; set; }

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

    [Column("tp_cls_active_ind")]
    [StringLength(1)]
    public string? TpClsActiveInd { get; set; }

    [InverseProperty("TpClsTyp")]
    public virtual ICollection<RgmSiteSeq> RgmSiteSeq { get; set; } = new List<RgmSiteSeq>();

    [InverseProperty("TpClsTyp")]
    public virtual ICollection<TpClsValue> TpClsValue { get; set; } = new List<TpClsValue>();
}
