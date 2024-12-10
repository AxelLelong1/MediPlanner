using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("rgm_site_seq")]
public partial class RgmSiteSeq
{
    [Key]
    [Column("rgm_site_seq_id")]
    public int RgmSiteSeqId { get; set; }

    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Column("tp_cls_value_from")]
    public int? TpClsValueFrom { get; set; }

    [Column("evidence_lvl_pln_typ")]
    public int? EvidenceLvlPlnTyp { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [ForeignKey("EvidenceLvlPlnTyp")]
    [InverseProperty("RgmSiteSeq")]
    public virtual PlnTyp? EvidenceLvlPlnTypNavigation { get; set; }

    [ForeignKey("TpClsTypId")]
    [InverseProperty("RgmSiteSeq")]
    public virtual TpClsTyp TpClsTyp { get; set; } = null!;

    [ForeignKey("TpName, TpVersNo")]
    [InverseProperty("RgmSiteSeq")]
    public virtual TxPln TxPln { get; set; } = null!;
}
